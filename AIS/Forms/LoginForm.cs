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
using System.Threading;

namespace AIS.Forms
{
    public partial class LoginForm : Form
    {
        private DataBaseInteraction db;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            db = new DataBaseInteraction();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //admin verystrongpassword123
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(db.Login(textBoxUsername.Text, textBoxPassword.Text))
            {
                MainForm form = new MainForm();
                form.Show();
                this.Close();              
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPassword.Text.Length > 0)
                {
                    loginButton_Click(sender, e);
                }
                else
                {
                    textBoxPassword.Focus();
                }
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxUsername.Text.Length > 0)
                {
                    loginButton_Click(sender, e);
                }
                else
                {
                    textBoxUsername.Focus();
                }
            }
        }
    }
}
