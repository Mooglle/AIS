using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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

        }
    }
}
