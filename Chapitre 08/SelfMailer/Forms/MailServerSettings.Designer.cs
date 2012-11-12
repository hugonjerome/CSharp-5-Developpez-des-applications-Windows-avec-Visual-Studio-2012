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
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.FromEmail = new System.Windows.Forms.TextBox();
            this.FromName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.lblFromName = new System.Windows.Forms.Label();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(99, 111);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(231, 20);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(99, 85);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(231, 20);
            this.Username.TabIndex = 3;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(99, 59);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(231, 20);
            this.Host.TabIndex = 2;
            // 
            // FromEmail
            // 
            this.FromEmail.Location = new System.Drawing.Point(99, 33);
            this.FromEmail.Name = "FromEmail";
            this.FromEmail.Size = new System.Drawing.Size(231, 20);
            this.FromEmail.TabIndex = 1;
            // 
            // FromName
            // 
            this.FromName.Location = new System.Drawing.Point(99, 7);
            this.FromName.Name = "FromName";
            this.FromName.Size = new System.Drawing.Size(231, 20);
            this.FromName.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Mot de passe:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(56, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Utilisateur:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(9, 62);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(33, 13);
            this.lblHost.TabIndex = 9;
            this.lblHost.Text = "Hôte:";
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Location = new System.Drawing.Point(9, 36);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(59, 13);
            this.lblFromEmail.TabIndex = 8;
            this.lblFromEmail.Text = "Email Exp.:";
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Location = new System.Drawing.Point(9, 10);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(56, 13);
            this.lblFromName.TabIndex = 7;
            this.lblFromName.Text = "Nom Exp.:";
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(174, 137);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(75, 23);
            this.Valid.TabIndex = 5;
            this.Valid.Text = "Valider";
            this.Valid.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(255, 137);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // MailServerSettings
            // 
            this.AcceptButton = this.Valid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(339, 166);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox FromEmail;
        private System.Windows.Forms.TextBox FromName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
    }
}