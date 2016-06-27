using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_Employee
{
    public  static class Connection
    {
        public static string ConnectionStr()
        {
            string str_connection = "";
            try
            {
                using (StreamReader reader = new StreamReader("ConnectionConfig.txt"))
                {
                    str_connection = string.Format(@"{0}", reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            return str_connection;
        }

        public static void LoadDataInTable(string cmdText, DataTable table)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr()))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(cmdText, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    try
                    {
                        //table.Clear();
                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }


        public static void RunTransaction(string cmbText)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr()))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("T1");
                cmd.Connection = connection;
                cmd.Transaction = transaction;
                try
                {
                    cmd.CommandText = cmbText;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Both records are written to database", "Sucsess", MessageBoxButtons.OK);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(string.Format("Commit Exeption Type: {0}.\n Message: {1}", 
                        ex1.GetType(), ex1.Message), "Error", MessageBoxButtons.OK);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(string.Format("Rollback Exeption Type: {0}.\n Message: {1}",
                            ex2.GetType(), ex2.Message), "Error", MessageBoxButtons.OK);
                    }

                }

            }
        }
    }
}
