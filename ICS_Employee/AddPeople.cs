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
    public partial class AddPeople : Form
    {
        public AddPeople()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length > 0 && tbLastName.Text.Length > 0 && dtpBirthday.Checked)
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionStr()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("spInsertPeople", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("FirstName", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("LastName", tbLastName.Text);
                        cmd.Parameters.AddWithValue("Birthday", dtpBirthday.Value.Date);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show("Success Inserting!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                        finally
                        {
                            this.Close();
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
