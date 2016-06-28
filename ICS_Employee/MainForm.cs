using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_Employee
{
    public partial class MainForm : Form
    {
        private DataTable tblEmployeeInfo = new DataTable("tblEmployeeInfo");
        private DataTable tblPositions = new DataTable("tblPositions");
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            DataRow newRow;
            DataColumn PositionName = new DataColumn("PositionName");
            tblPositions.Columns.Add(PositionName);

            newRow = tblPositions.NewRow();
            newRow["PositionName"] = "All";
            tblPositions.Rows.Add(newRow);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Format("Connection error: {0}", ex.GetType()));
                }

                string cmd_SelectEmpInfo = string.Format("SELECT * FROM [ICSDB].[dbo].[vwEmployeeInfo_v1]");
                Connection.LoadDataInTable(cmd_SelectEmpInfo, tblEmployeeInfo);
                dgvEmpInfo.DataSource = tblEmployeeInfo;



                string cmd_LoadPositions = string.Format("SELECT DISTINCT p.PositionName FROM Position AS p ORDER BY p.PositionName ASC");
                Connection.LoadDataInTable(cmd_LoadPositions, tblPositions);
                cmbbPositions.DataSource = tblPositions;
                cmbbPositions.DisplayMember = "PositionName";
            }
        }

        private void cmbbPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmd_SelectEmpInfo = string.Format("SELECT * FROM [ICSDB].[dbo].[vwEmployeeInfo_v1] " +
                                                                        "WHERE PositionName LIKE '%{0}%'",
                                                cmbbPositions.Text == "All" ? "" : cmbbPositions.Text);
            tblEmployeeInfo.Clear();
            Connection.LoadDataInTable(cmd_SelectEmpInfo, tblEmployeeInfo);
            dgvEmpInfo.DataSource = tblEmployeeInfo;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddEmployee().ShowDialog();
            tblEmployeeInfo.Clear();
            string cmd_SelectEmpInfo = string.Format("SELECT * FROM [ICSDB].[dbo].[vwEmployeeInfo_v1]");
            Connection.LoadDataInTable(cmd_SelectEmpInfo, tblEmployeeInfo);
            dgvEmpInfo.DataSource = tblEmployeeInfo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSackEmp_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Delete this record. Are you sure?", "DeleteDialog", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                var currRow = (dgvEmpInfo.CurrentRow.DataBoundItem as DataRowView).Row;
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("spSackEmployee", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("FirstName", currRow["FirstName"].ToString());
                        cmd.Parameters.AddWithValue("LastName", currRow["LastName"]);
                        cmd.Parameters.AddWithValue("Birthday", currRow["Birthday"].ToString());
                        cmd.Parameters.AddWithValue("PositionName", currRow["PositionName"].ToString());
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Success Sacking!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                        finally
                        {
                            tblEmployeeInfo.Clear();
                            string cmd_SelectEmpInfo = string.Format("SELECT * FROM [ICSDB].[dbo].[vwEmployeeInfo_v1]");
                            Connection.LoadDataInTable(cmd_SelectEmpInfo, tblEmployeeInfo);
                            dgvEmpInfo.DataSource = tblEmployeeInfo;
                        }
                    }
                }
            }
        }
    }
}
