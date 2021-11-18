using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AIS.Modules
{
    public class DataBaseInteraction
    {
        private SqlConnection connection;
        public DataBaseInteraction()
        {

        }
        private void Connect(Form form)
        {
            form.FormClosing += Disconnect;
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\AIS\\AIS\\AIS\\SuperStoreDB.mdf;Integrated Security=True");
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
                catch (SqlException)
                {
                    MessageBox.Show("Data Base is unavailable", "DB connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Dispose();
                    return false;
                }

            }
            else
            {
                return true;
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

        public void CreateAccount(string username, string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\AIS\\AIS\\AIS\\EmployeesAccounts.mdf;Integrated Security=True";
            conn.Open();
            var command = new SqlCommand($"INSERT INTO Accounts (username, password) VALUES ('{username}', '{savedPasswordHash}');", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public bool Login(string username, string password)
        {
            if (username.Length < 1 || password.Length < 1)
                return false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\AIS\\AIS\\AIS\\EmployeesAccounts.mdf;Integrated Security=True";
            conn.Open();
            var command = new SqlCommand($"Select password FROM Accounts Where username = '{username}'", conn);
            /* Fetch the stored value */
            string savedPasswordHash = command.ExecuteScalar().ToString();
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                {
                    MessageBox.Show("Incorrect username or password", "Authentication has failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                }
            conn.Close();
            return true;
        }
    }
}
