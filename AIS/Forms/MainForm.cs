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

namespace AIS
{
    public partial class MainForm : Form
    {
        private DataBaseInteraction db;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DataBaseInteraction();
            db.Connect(this);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
