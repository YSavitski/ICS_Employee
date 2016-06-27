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
                        adapter.Fill(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), ex.GetType().ToString(), MessageBoxButtons.RetryCancel);
                    }
                }
            }
        }
    }
}
