namespace SelfMailer.Forms
{
    partial class LoadBody
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
            this.Body = new System.Windows.Forms.TextBox();
            this.Valid = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.ofdMailBody = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(415, 51);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(12, 25);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(478, 20);
            this.Body.TabIndex = 0;
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(334, 51);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(75, 23);
            this.Valid.TabIndex = 2;
            this.Valid.Text = "Valider";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Choisir un fichier ou saisir une URL :";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(12, 51);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Parcourir ...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // ofdMailBody
            // 
            this.ofdMailBody.RestoreDirectory = true;
            this.ofdMailBody.SupportMultiDottedExtensions = true;
            this.ofdMailBody.Title = "Charger un modèle";
            // 
            // LoadBody
            // 
            this.AcceptButton = this.Valid;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(502, 86);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadBody";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Charger le corps du mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog ofdMailBody;
    }
}