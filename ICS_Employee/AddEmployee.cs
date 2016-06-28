using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_Employee
{
    public partial class AddEmployee : Form
    {
        private DataTable tblSearchPeople = new DataTable("tblSearchPeople");
        private DataTable tblSearchPosition = new DataTable("tblSearchPosition");
        public AddEmployee()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Connection.LoadDataInTable(string.Format("SELECT p.FirstName, p.LastName, p.Birthday FROM People AS p"), tblSearchPeople);
            Connection.LoadDataInTable(string.Format("SELECT DISTINCT p.PositionName FROM Position AS p"), tblSearchPosition);
            dgvSearchPeople.DataSource = tblSearchPeople;
            dgvSearchPosition.DataSource = tblSearchPosition;
        }

        private void btnSearchPeople_Click(object sender, EventArgs e)
        {
            tblSearchPeople.Clear();
            Connection.LoadDataInTable(string.Format("SELECT p.FirstName, p.LastName, p.Birthday FROM People AS p " +
                                                     "WHERE p.FirstName LIKE '%{0}%' OR p.LastName LIKE '%{0}%' OR p.Birthday LIKE '%{0}%'",
                                                     tbSearchPeople.Text), tblSearchPeople);
            dgvSearchPeople.DataSource = tblSearchPeople;
        }

        private void btnSearchPosition_Click(object sender, EventArgs e)
        {
            tblSearchPosition.Clear();
            Connection.LoadDataInTable(string.Format("SELECT DISTINCT p.PositionName FROM Position AS p " +
                                                     "WHERE p.PositionName LIKE '%{0}%'", tbSearchPosition.Text), tblSearchPosition);
            dgvSearchPosition.DataSource = tblSearchPosition;
        }

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddPeople().ShowDialog();
            tblSearchPeople.Clear();
            Connection.LoadDataInTable(string.Format("SELECT p.FirstName, p.LastName, p.Birthday FROM People AS p"), tblSearchPeople);
            dgvSearchPeople.DataSource = tblSearchPeople;
        }



        private void tbSalary_TextChanged(object sender, EventArgs e)
        {
            if (tbSalary.Text.Length > 0)
            {
                try
                {
                    Convert.ToDecimal(tbSalary.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnInfoPeople_Click(object sender, EventArgs e)
        {
            tbFirstName.ReadOnly = false;
            tbLastName.ReadOnly = false;
            tbBirthday.ReadOnly = false;
            try
            {
                var currRowPeople = (dgvSearchPeople.CurrentRow.DataBoundItem as DataRowView).Row;
                tbFirstName.Text = currRowPeople["FirstName"].ToString();
                tbLastName.Text = currRowPeople["LastName"].ToString();
                tbBirthday.Text = currRowPeople["Birthday"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                tbFirstName.ReadOnly = true;
                tbLastName.ReadOnly = true;
                tbBirthday.ReadOnly = true;
            }
        }

        private void btnInfoPosition_Click(object sender, EventArgs e)
        {
            tbPosition.ReadOnly = false;
            try
            {
                var currRowPosition = (dgvSearchPosition.CurrentRow.DataBoundItem as DataRowView).Row;
                tbPosition.Text = currRowPosition["PositionName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            finally
            {
                tbPosition.ReadOnly = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length > 0 && tbLastName.Text.Length > 0 && tbBirthday.Text.Length > 0 &&
                tbPosition.Text.Length > 0)
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("spInsertEmployee", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("LastName", tbLastName.Text);
                        cmd.Parameters.AddWithValue("FirstName", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("Birthday", Convert.ToDateTime(tbBirthday.Text));
                        cmd.Parameters.AddWithValue("PositionName", tbPosition.Text);
                        cmd.Parameters.AddWithValue("Salary", tbSalary.Text.Length>0 ? Convert.ToDecimal(tbSalary.Text) : 0);
                        cmd.Parameters.AddWithValue("Sacked", 0);
                        cmd.Parameters.AddWithValue("LastModify", DateTime.Now);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Success Inserting!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                        finally
                        {
                            tbFirstName.ReadOnly = false;
                            tbLastName.ReadOnly = false;
                            tbBirthday.ReadOnly = false;
                            tbPosition.ReadOnly = false;

                            tbFirstName.Clear();
                            tbLastName.Clear();
                            tbBirthday.Clear();
                            tbPosition.Clear();
                            tbSalary.Clear();

                            tbFirstName.ReadOnly = true;
                            tbLastName.ReadOnly = true;
                            tbBirthday.ReadOnly = true;
                            tbPosition.ReadOnly = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect input data in textboxes", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
