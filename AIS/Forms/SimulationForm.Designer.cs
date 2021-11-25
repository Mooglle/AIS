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
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 443);
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
    }
}