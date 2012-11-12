namespace SelfMailer.Forms
{
    partial class GDISamples
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
            this.customControl1 = new SelfMailer.Controls.CustomControl();
            this.SuspendLayout();
            // 
            // customControl1
            // 
            this.customControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customControl1.Location = new System.Drawing.Point(0, 0);
            this.customControl1.Name = "customControl1";
            this.customControl1.Size = new System.Drawing.Size(218, 60);
            this.customControl1.TabIndex = 0;
            this.customControl1.Text = "customControl1";
            // 
            // GDISamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 60);
            this.Controls.Add(this.customControl1);
            this.Name = "GDISamples";
            this.Text = "GDISamples";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomControl customControl1;
    }
}