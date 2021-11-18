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
    public partial class LoginForm : Form
    {
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
            generation.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            generation.Stop();
        }
        Modules.Simulation generation;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            generation = new Modules.Simulation();
            generation.label = label1;
        }
    }
}
