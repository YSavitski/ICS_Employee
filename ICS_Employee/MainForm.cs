﻿using System;
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
        private DataTable tblPeoples = new DataTable("tblPeoples");
        private DataTable tblPositions = new DataTable("tblPositions");
        private SqlDataAdapter mainAdapter;
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

                SqlCommand cmd_SelectEmpInfo = new SqlCommand(string.Format("SELECT * FROM [ICSDB].[dbo].[vwEmployeeInfo_v1]"), connection);
                LoadData(mainAdapter, cmd_SelectEmpInfo, tblEmployeeInfo);
                dgvEmpInfo.DataSource = tblEmployeeInfo;



                SqlCommand cmd_LoadPositions = new SqlCommand(string.Format("SELECT DISTINCT p.PositionName FROM Position AS p ORDER BY p.PositionName ASC"), connection);
                LoadData(mainAdapter, cmd_LoadPositions, tblPositions);
                cmbbPositions.DataSource = tblPositions;
                cmbbPositions.DisplayMember = "PositionName";
                
            }
        }

        private void cmbbPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
            {
                SqlCommand cmd_SelectEmpInfo = new SqlCommand(string.Format("SELECT * FROM [ICSDB].[dbo].[vwEmployeeInfo_v1] " +
                                                                            "WHERE PositionName LIKE '%{0}%'",
                                                    cmbbPositions.Text == "All" ? "" : cmbbPositions.Text), connection);
                tblEmployeeInfo.Clear();
                LoadData(mainAdapter, cmd_SelectEmpInfo, tblEmployeeInfo);
                dgvEmpInfo.DataSource = tblEmployeeInfo;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(SqlDataAdapter adapter, SqlCommand cmd, DataTable table)
        {
            using (adapter = new SqlDataAdapter(cmd))
            {
                try
                {
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                }
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddEmployee().ShowDialog();
        }
    }
}
