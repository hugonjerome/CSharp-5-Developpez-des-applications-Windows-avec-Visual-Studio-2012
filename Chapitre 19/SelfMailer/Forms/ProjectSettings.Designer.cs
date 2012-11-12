namespace SelfMailer.Forms
{
    partial class ProjectSettings
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Valid = new System.Windows.Forms.Button();
            this.lblSendDelay = new System.Windows.Forms.Label();
            this.SendDelay = new System.Windows.Forms.NumericUpDown();
            this.lblLanguageField = new System.Windows.Forms.Label();
            this.lblEmailField = new System.Windows.Forms.Label();
            this.LanguageField = new System.Windows.Forms.ComboBox();
            this.EmailField = new System.Windows.Forms.ComboBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.BrowseLog = new System.Windows.Forms.Button();
            this.sfdLog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SendDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(374, 118);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(293, 118);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(75, 23);
            this.Valid.TabIndex = 12;
            this.Valid.Text = "Valider";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // lblSendDelay
            // 
            this.lblSendDelay.AutoSize = true;
            this.lblSendDelay.Location = new System.Drawing.Point(5, 40);
            this.lblSendDelay.Name = "lblSendDelay";
            this.lblSendDelay.Size = new System.Drawing.Size(96, 13);
            this.lblSendDelay.TabIndex = 15;
            this.lblSendDelay.Text = "Délai d\'envoi (ms) :";
            // 
            // SendDelay
            // 
            this.SendDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SendDelay.Location = new System.Drawing.Point(121, 38);
            this.SendDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SendDelay.Name = "SendDelay";
            this.SendDelay.Size = new System.Drawing.Size(328, 20);
            this.SendDelay.TabIndex = 1;
            // 
            // lblLanguageField
            // 
            this.lblLanguageField.AutoSize = true;
            this.lblLanguageField.Location = new System.Drawing.Point(5, 67);
            this.lblLanguageField.Name = "lblLanguageField";
            this.lblLanguageField.Size = new System.Drawing.Size(81, 13);
            this.lblLanguageField.TabIndex = 21;
            this.lblLanguageField.Text = "Champ langue :";
            // 
            // lblEmailField
            // 
            this.lblEmailField.AutoSize = true;
            this.lblEmailField.Location = new System.Drawing.Point(5, 94);
            this.lblEmailField.Name = "lblEmailField";
            this.lblEmailField.Size = new System.Drawing.Size(73, 13);
            this.lblEmailField.TabIndex = 22;
            this.lblEmailField.Text = "Champ email :";
            // 
            // LanguageField
            // 
            this.LanguageField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageField.FormattingEnabled = true;
            this.LanguageField.Location = new System.Drawing.Point(121, 64);
            this.LanguageField.Name = "LanguageField";
            this.LanguageField.Size = new System.Drawing.Size(328, 21);
            this.LanguageField.TabIndex = 7;
            // 
            // EmailField
            // 
            this.EmailField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmailField.FormattingEnabled = true;
            this.EmailField.Location = new System.Drawing.Point(121, 91);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(328, 21);
            this.EmailField.TabIndex = 8;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(121, 12);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(247, 20);
            this.Log.TabIndex = 0;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(5, 15);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(47, 13);
            this.lblLog.TabIndex = 14;
            this.lblLog.Text = "Journal :";
            // 
            // BrowseLog
            // 
            this.BrowseLog.Location = new System.Drawing.Point(374, 10);
            this.BrowseLog.Name = "BrowseLog";
            this.BrowseLog.Size = new System.Drawing.Size(75, 23);
            this.BrowseLog.TabIndex = 26;
            this.BrowseLog.Text = "Parcourir ...";
            this.BrowseLog.UseVisualStyleBackColor = true;
            this.BrowseLog.Click += new System.EventHandler(this.BrowseLog_Click);
            // 
            // sfdLog
            // 
            this.sfdLog.Filter = "Fichier texte (*.txt)|*.txt";
            this.sfdLog.RestoreDirectory = true;
            this.sfdLog.SupportMultiDottedExtensions = true;
            this.sfdLog.Title = "Sauver";
            // 
            // ProjectSettings
            // 
            this.AcceptButton = this.Valid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(461, 154);
            this.Controls.Add(this.BrowseLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.LanguageField);
            this.Controls.Add(this.lblEmailField);
            this.Controls.Add(this.lblLanguageField);
            this.Controls.Add(this.SendDelay);
            this.Controls.Add(this.lblSendDelay);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres du projet";
            ((System.ComponentModel.ISupportInitialize)(this.SendDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Label lblSendDelay;
        private System.Windows.Forms.NumericUpDown SendDelay;
        private System.Windows.Forms.Label lblLanguageField;
        private System.Windows.Forms.Label lblEmailField;
        private System.Windows.Forms.ComboBox LanguageField;
        private System.Windows.Forms.ComboBox EmailField;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button BrowseLog;
        private System.Windows.Forms.SaveFileDialog sfdLog;
    }
}