namespace SelfMailer.Forms
{
    partial class PreviewBody
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
            this.wbBody = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbBody
            // 
            this.wbBody.AllowNavigation = false;
            this.wbBody.AllowWebBrowserDrop = false;
            this.wbBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBody.IsWebBrowserContextMenuEnabled = false;
            this.wbBody.Location = new System.Drawing.Point(0, 0);
            this.wbBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBody.Name = "wbBody";
            this.wbBody.ScriptErrorsSuppressed = true;
            this.wbBody.Size = new System.Drawing.Size(727, 472);
            this.wbBody.TabIndex = 0;
            this.wbBody.WebBrowserShortcutsEnabled = false;
            // 
            // PreviewBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 472);
            this.Controls.Add(this.wbBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PreviewBody";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prévisualiser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBody;
    }
}