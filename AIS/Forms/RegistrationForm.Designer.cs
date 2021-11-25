namespace AIS.Forms
{
    partial class RegistrationForm
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
            this.tabControlRegistration = new System.Windows.Forms.TabControl();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.labelIncorrectData = new System.Windows.Forms.Label();
            this.tabControlRegistration.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRegistration
            // 
            this.tabControlRegistration.Controls.Add(this.tabPageAccount);
            this.tabControlRegistration.Controls.Add(this.tabPageClients);
            this.tabControlRegistration.Location = new System.Drawing.Point(12, 2);
            this.tabControlRegistration.Name = "tabControlRegistration";
            this.tabControlRegistration.SelectedIndex = 0;
            this.tabControlRegistration.Size = new System.Drawing.Size(653, 530);
            this.tabControlRegistration.TabIndex = 0;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.labelIncorrectData);
            this.tabPageAccount.Controls.Add(this.passwordLabel);
            this.tabPageAccount.Controls.Add(this.nameLabel);
            this.tabPageAccount.Controls.Add(this.textBoxPassword);
            this.tabPageAccount.Controls.Add(this.textBoxUsername);
            this.tabPageAccount.Controls.Add(this.registrationButton);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(645, 504);
            this.tabPageAccount.TabIndex = 0;
            this.tabPageAccount.Text = "Accounts";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(221, 160);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Пароль";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(221, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Имя";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(224, 185);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(190, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(224, 118);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(190, 20);
            this.textBoxUsername.TabIndex = 7;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(256, 369);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(143, 23);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегистрировать";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // tabPageClients
            // 
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(645, 504);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Clients";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // labelIncorrectData
            // 
            this.labelIncorrectData.AutoSize = true;
            this.labelIncorrectData.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrectData.Location = new System.Drawing.Point(239, 239);
            this.labelIncorrectData.Name = "labelIncorrectData";
            this.labelIncorrectData.Size = new System.Drawing.Size(175, 13);
            this.labelIncorrectData.TabIndex = 11;
            this.labelIncorrectData.Text = "Неправильный логин или пароль";
            this.labelIncorrectData.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 544);
            this.Controls.Add(this.tabControlRegistration);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.tabControlRegistration.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRegistration;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label labelIncorrectData;
    }
}