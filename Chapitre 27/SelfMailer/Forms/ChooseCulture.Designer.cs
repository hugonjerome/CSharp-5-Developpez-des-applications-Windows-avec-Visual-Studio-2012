namespace SelfMailer.Forms
{
    partial class ChooseCulture
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
            this.CultureList = new System.Windows.Forms.ComboBox();
            this.lblCulture = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CultureList
            // 
            this.CultureList.FormattingEnabled = true;
            this.CultureList.Location = new System.Drawing.Point(12, 12);
            this.CultureList.Name = "CultureList";
            this.CultureList.Size = new System.Drawing.Size(264, 21);
            this.CultureList.TabIndex = 0;
            this.CultureList.SelectedIndexChanged += new System.EventHandler(this.CultureList_SelectedIndexChanged);
            // 
            // lblCulture
            // 
            this.lblCulture.AutoSize = true;
            this.lblCulture.Location = new System.Drawing.Point(12, 36);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.Size = new System.Drawing.Size(43, 13);
            this.lblCulture.TabIndex = 1;
            this.lblCulture.Text = "Culture:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(12, 62);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(51, 13);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Monnaie:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // ChooseCulture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 83);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCulture);
            this.Controls.Add(this.CultureList);
            this.Name = "ChooseCulture";
            this.Text = "Choix de la culture";
            this.Load += new System.EventHandler(this.ChooseCulture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CultureList;
        private System.Windows.Forms.Label lblCulture;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDate;
    }
}