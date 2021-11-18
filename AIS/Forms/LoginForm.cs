using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIS.Modules;
using System.Diagnostics;

namespace AIS.Forms
{
    public partial class LoginForm : Form
    {
        private DataBaseInteraction db;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            M2(textBox1.Text, textBox2.Text);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            db = new DataBaseInteraction(this);
        }
        private void M(string username, string password)
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
        private void M2(string username, string password)
        {
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
                    throw new UnauthorizedAccessException();
            conn.Close();
            Debug.WriteLine("ok");
        }
    }
}
