namespace AIS.Forms
{
    partial class SimulationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTrigger = new System.Windows.Forms.Button();
            this.labelMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTrigger
            // 
            this.buttonTrigger.Location = new System.Drawing.Point(43, 30);
            this.buttonTrigger.Name = "buttonTrigger";
            this.buttonTrigger.Size = new System.Drawing.Size(75, 23);
            this.buttonTrigger.TabIndex = 0;
            this.buttonTrigger.Text = "Старт";
            this.buttonTrigger.UseVisualStyleBackColor = true;
            this.buttonTrigger.Click += new System.EventHandler(this.buttonTrigger_Click);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(43, 110);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(31, 13);
            this.labelMoney.TabIndex = 1;
            this.labelMoney.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вероятность появления нового клиента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0.75";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 443);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.buttonTrigger);
            this.Name = "SimulationForm";
            this.Text = "Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrigger;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}