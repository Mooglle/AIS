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
            var command = new SqlCommand(sqlCommand, connection);
            command.ExecuteNonQuery();
        }
        public bool IsAccountValid(string username, string password, string role)
        {
            SqlConnection securityConnection = new SqlConnection();
            string sql_command = $"SELECT count(*) FROM Accounts WHERE name = {username};";
            bool SqlUserExists;

            using (SqlCommand command = new SqlCommand(sql_command, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetValue(0).ToString() == "1")
                        {
                            SqlUserExists = true;
                        }
                    }
                }
            }
            SqlUserExists = false;


            if (SqlUserExists)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=.;" + "User id=" + username + ";Password=" + password + ";";
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    connection.Dispose();
                    return false;
                }

            }
            else
            {
                return true; // it is not a problem for me if account does not exist (as it will be created later), I am only worried about the case when the credentials are wrong
            }
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
