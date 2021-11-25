using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIS.Modules;
using AIS.Forms;

namespace AIS.Forms
{
    public partial class RegistrationForm : Form
    {
        public DataBaseInteraction db;
        public RegistrationForm(DataBaseInteraction dataBase)
        {
            InitializeComponent();
            db = dataBase;
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPassword.Text.Length > 0)
                {
                    registrationButton_Click(sender, e);
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
                    registrationButton_Click(sender, e);
                }
                else
                {
                    textBoxUsername.Focus();
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            db.CreateAccount(textBoxUsername.Text, textBoxPassword.Text);
        }

        private void buttonRegClient_Click(object sender, EventArgs e)
        {
            db.InsertClient(textBoxClientName.Text);
        }
    }
}
