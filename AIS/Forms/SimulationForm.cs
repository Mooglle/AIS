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
    public partial class SimulationForm : Form
    {
        private bool _isRunning = false;
        private Simulation _sim;

        public SimulationForm()
        {
            InitializeComponent();
            _sim = new Simulation(labelMoney);
        }

        private void buttonTrigger_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _sim.Start();
                buttonTrigger.Text = "Стоп";
            }
            else
            {
                _sim.Stop();
                buttonTrigger.Text = "Старт";
            }
            _isRunning = !_isRunning;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _sim.config.newClientRate = Double.Parse(textBox1.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _sim.config.autoDecay = true;
            }
            else
            {
                _sim.config.autoDecay = false;
            }
        }
    }
}
