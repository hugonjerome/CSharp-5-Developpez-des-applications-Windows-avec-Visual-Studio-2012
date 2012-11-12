namespace SelfMailer.Forms
{
    partial class Send
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
            this.SendPerSecondCounter = new System.Diagnostics.PerformanceCounter();
            this.SendPerSecondValue = new System.Windows.Forms.Label();
            this.SendPerSecondTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SendPerSecondCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // SendPerSecondCounter
            // 
            this.SendPerSecondCounter.CategoryName = "SelfMailer";
            this.SendPerSecondCounter.CounterName = "SendPerSecond";
            // 
            // SendPerSecondValue
            // 
            this.SendPerSecondValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendPerSecondValue.AutoSize = true;
            this.SendPerSecondValue.Location = new System.Drawing.Point(12, 30);
            this.SendPerSecondValue.Name = "SendPerSecondValue";
            this.SendPerSecondValue.Size = new System.Drawing.Size(92, 13);
            this.SendPerSecondValue.TabIndex = 0;
            this.SendPerSecondValue.Text = "0 email / seconde";
            // 
            // SendPerSecondTimer
            // 
            this.SendPerSecondTimer.Enabled = true;
            this.SendPerSecondTimer.Interval = 1000;
            this.SendPerSecondTimer.Tick += new System.EventHandler(this.SendPerSecondTimer_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 52);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.SendPerSecondValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Send";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send";
            ((System.ComponentModel.ISupportInitialize)(this.SendPerSecondCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter SendPerSecondCounter;
        private System.Windows.Forms.Label SendPerSecondValue;
        private System.Windows.Forms.Timer SendPerSecondTimer;
        private System.Windows.Forms.Label lblStatus;
    }
}