namespace SelfMailer.Forms
{
    partial class MailServerSettings
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
            this.components = new System.ComponentModel.Container();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.FromName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.lblFromName = new System.Windows.Forms.Label();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FromEmail = new SelfMailer.Controls.EmailTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(99, 156);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(228, 20);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(99, 130);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(228, 20);
            this.Username.TabIndex = 3;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(99, 104);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(228, 20);
            this.Host.TabIndex = 2;
            // 
            // FromName
            // 
            this.FromName.Location = new System.Drawing.Point(99, 52);
            this.FromName.Name = "FromName";
            this.FromName.Size = new System.Drawing.Size(228, 20);
            this.FromName.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Mot de passe:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 133);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(56, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Utilisateur:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(12, 107);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(33, 13);
            this.lblHost.TabIndex = 9;
            this.lblHost.Text = "Hôte:";
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Location = new System.Drawing.Point(12, 81);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(59, 13);
            this.lblFromEmail.TabIndex = 8;
            this.lblFromEmail.Text = "Email Exp.:";
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Location = new System.Drawing.Point(12, 55);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(56, 13);
            this.lblFromName.TabIndex = 7;
            this.lblFromName.Text = "Nom Exp.:";
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(171, 182);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(75, 23);
            this.Valid.TabIndex = 5;
            this.Valid.Text = "Valider";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(252, 182);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(99, 78);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(228, 20);
            this.FromEmail.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 182);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Sauver";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Charger la configuration suivante:";
            // 
            // ConfigList
            // 
            this.ConfigList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.Location = new System.Drawing.Point(12, 25);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(315, 21);
            this.ConfigList.TabIndex = 14;
            this.ConfigList.SelectedIndexChanged += new System.EventHandler(this.ConfigList_SelectedIndexChanged);
            // 
            // MailServerSettings
            // 
            this.AcceptButton = this.Valid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(339, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfigList);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.FromEmail);
            this.Controls.Add(this.FromName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblFromEmail);
            this.Controls.Add(this.lblFromName);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailServerSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres du serveur mail";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Host;
        private Controls.EmailTextBox FromEmail;
        private System.Windows.Forms.TextBox FromName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox ConfigList;
    }
}