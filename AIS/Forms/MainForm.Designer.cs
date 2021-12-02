namespace AIS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonOpenRegForm = new System.Windows.Forms.Button();
            this.buttonOpenSimulation = new System.Windows.Forms.Button();
            this.buttonOpenDBInspector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Location = new System.Drawing.Point(144, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(644, 426);
            this.panelMain.TabIndex = 3;
            // 
            // buttonOpenRegForm
            // 
            this.buttonOpenRegForm.Location = new System.Drawing.Point(12, 21);
            this.buttonOpenRegForm.Name = "buttonOpenRegForm";
            this.buttonOpenRegForm.Size = new System.Drawing.Size(100, 93);
            this.buttonOpenRegForm.TabIndex = 4;
            this.buttonOpenRegForm.Text = "Форма регистрации";
            this.buttonOpenRegForm.UseVisualStyleBackColor = true;
            this.buttonOpenRegForm.Click += new System.EventHandler(this.buttonOpenRegForm_Click);
            // 
            // buttonOpenSimulation
            // 
            this.buttonOpenSimulation.Location = new System.Drawing.Point(12, 140);
            this.buttonOpenSimulation.Name = "buttonOpenSimulation";
            this.buttonOpenSimulation.Size = new System.Drawing.Size(100, 93);
            this.buttonOpenSimulation.TabIndex = 5;
            this.buttonOpenSimulation.Text = "Форма симуляции";
            this.buttonOpenSimulation.UseVisualStyleBackColor = true;
            this.buttonOpenSimulation.Click += new System.EventHandler(this.buttonOpenSimulation_Click);
            // 
            // buttonOpenDBInspector
            // 
            this.buttonOpenDBInspector.Location = new System.Drawing.Point(12, 258);
            this.buttonOpenDBInspector.Name = "buttonOpenDBInspector";
            this.buttonOpenDBInspector.Size = new System.Drawing.Size(100, 93);
            this.buttonOpenDBInspector.TabIndex = 6;
            this.buttonOpenDBInspector.Text = "Форма БД";
            this.buttonOpenDBInspector.UseVisualStyleBackColor = true;
            this.buttonOpenDBInspector.Click += new System.EventHandler(this.buttonOpenDBInspector_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenDBInspector);
            this.Controls.Add(this.buttonOpenSimulation);
            this.Controls.Add(this.buttonOpenRegForm);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonOpenRegForm;
        private System.Windows.Forms.Button buttonOpenSimulation;
        private System.Windows.Forms.Button buttonOpenDBInspector;
    }
}

