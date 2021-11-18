using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AIS.Modules
{
    public class DataBaseInteraction
    {
        private SqlConnection connection;
        public DataBaseInteraction(Form form)
        {
            form.FormClosing += Disconnect;
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\AIS\\AIS\\AIS\\SuperStoreDB.mdf;Integrated Security=True");
            Connect();
        }
        private void Connect()
        {
            if (IsAvailable())
            {
                connection.Open();
            }
        }

        public void Insert(string sqlCommand)
        {
            var commannd = new SqlCommand(sqlCommand, connection);
            commannd.ExecuteNonQuery();
        }


        private void Disconnect(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
        private bool IsAvailable()
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Data Base is unavailable", "DB connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
