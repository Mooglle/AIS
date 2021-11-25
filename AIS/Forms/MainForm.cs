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

namespace AIS
{
    public partial class MainForm : Form
    {
        private DataBaseInteraction _db;
        private Form _currentChildForm;
        private Dictionary<string, Form> _forms = new Dictionary<string, Form>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _db = new DataBaseInteraction();
            _db.Connect(this);

            _forms.Add("Registration", new RegistrationForm());
        }
        private void OpenChildForm(Form childForm)
        {
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _db.Insert($"INSERT INTO CLIENTS (name) VALUES ('{textBox1.Text}');");
        }

        private void buttonOpenRegForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(_forms["Registration"]);
        }
    }
}
