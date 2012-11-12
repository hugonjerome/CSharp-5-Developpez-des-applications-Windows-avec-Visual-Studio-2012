namespace SelfMailer.Controls
{
    partial class MailProperties
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSendType = new System.Windows.Forms.Label();
            this.SendType = new System.Windows.Forms.ComboBox();
            this.MailContent = new System.Windows.Forms.GroupBox();
            this.PreviewBody = new System.Windows.Forms.Button();
            this.LoadBody = new System.Windows.Forms.Button();
            this.lblBody = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.MailContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSendType
            // 
            this.lblSendType.AutoSize = true;
            this.lblSendType.Location = new System.Drawing.Point(3, 6);
            this.lblSendType.Name = "lblSendType";
            this.lblSendType.Size = new System.Drawing.Size(74, 13);
            this.lblSendType.TabIndex = 1;
            this.lblSendType.Text = "Type d\'envoi :";
            // 
            // SendType
            // 
            this.SendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SendType.FormattingEnabled = true;
            this.SendType.Location = new System.Drawing.Point(83, 3);
            this.SendType.Name = "SendType";
            this.SendType.Size = new System.Drawing.Size(243, 21);
            this.SendType.TabIndex = 2;
            this.SendType.SelectedIndexChanged += new System.EventHandler(this.SendType_SelectedIndexChanged);
            // 
            // MailContent
            // 
            this.MailContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MailContent.Controls.Add(this.PreviewBody);
            this.MailContent.Controls.Add(this.LoadBody);
            this.MailContent.Controls.Add(this.lblBody);
            this.MailContent.Controls.Add(this.Subject);
            this.MailContent.Controls.Add(this.lblSubject);
            this.MailContent.Enabled = false;
            this.MailContent.Location = new System.Drawing.Point(6, 30);
            this.MailContent.Name = "MailContent";
            this.MailContent.Size = new System.Drawing.Size(324, 78);
            this.MailContent.TabIndex = 3;
            this.MailContent.TabStop = false;
            this.MailContent.Text = "Contenu";
            // 
            // PreviewBody
            // 
            this.PreviewBody.Location = new System.Drawing.Point(158, 45);
            this.PreviewBody.Name = "PreviewBody";
            this.PreviewBody.Size = new System.Drawing.Size(75, 23);
            this.PreviewBody.TabIndex = 4;
            this.PreviewBody.Text = "Aperçu";
            this.PreviewBody.UseVisualStyleBackColor = true;
            this.PreviewBody.Click += new System.EventHandler(this.PreviewBody_Click);
            // 
            // LoadBody
            // 
            this.LoadBody.Location = new System.Drawing.Point(77, 45);
            this.LoadBody.Name = "LoadBody";
            this.LoadBody.Size = new System.Drawing.Size(75, 23);
            this.LoadBody.TabIndex = 3;
            this.LoadBody.Text = "Parcourir ...";
            this.LoadBody.UseVisualStyleBackColor = true;
            this.LoadBody.Click += new System.EventHandler(this.LoadBody_Click);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(6, 50);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(40, 13);
            this.lblBody.TabIndex = 2;
            this.lblBody.Text = "Corps :";
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject.Location = new System.Drawing.Point(77, 19);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(241, 20);
            this.Subject.TabIndex = 1;
            this.Subject.TextChanged += new System.EventHandler(this.Subject_TextChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 22);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(37, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Sujet :";
            // 
            // MailProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MailContent);
            this.Controls.Add(this.SendType);
            this.Controls.Add(this.lblSendType);
            this.Name = "MailProperties";
            this.Size = new System.Drawing.Size(333, 116);
            this.Load += new System.EventHandler(this.MailProperties_Load);
            this.MailContent.ResumeLayout(false);
            this.MailContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendType;
        private System.Windows.Forms.ComboBox SendType;
        private System.Windows.Forms.GroupBox MailContent;
        private System.Windows.Forms.Button PreviewBody;
        private System.Windows.Forms.Button LoadBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label lblSubject;
    }
}
