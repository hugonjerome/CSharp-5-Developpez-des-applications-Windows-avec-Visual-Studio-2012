namespace SelfMailer.Forms
{
    partial class PreviewData
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
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.lblDeleteColumn = new System.Windows.Forms.Label();
            this.cbDeleteColumn = new System.Windows.Forms.ComboBox();
            this.btDeleteColumn = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreview
            // 
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPreview.Location = new System.Drawing.Point(0, 0);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.Size = new System.Drawing.Size(622, 480);
            this.dgvPreview.TabIndex = 0;
            // 
            // lblDeleteColumn
            // 
            this.lblDeleteColumn.AutoSize = true;
            this.lblDeleteColumn.Location = new System.Drawing.Point(151, 489);
            this.lblDeleteColumn.Name = "lblDeleteColumn";
            this.lblDeleteColumn.Size = new System.Drawing.Size(122, 13);
            this.lblDeleteColumn.TabIndex = 4;
            this.lblDeleteColumn.Text = "Supprimer une colonne :";
            // 
            // cbDeleteColumn
            // 
            this.cbDeleteColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeleteColumn.FormattingEnabled = true;
            this.cbDeleteColumn.Location = new System.Drawing.Point(279, 486);
            this.cbDeleteColumn.Name = "cbDeleteColumn";
            this.cbDeleteColumn.Size = new System.Drawing.Size(250, 21);
            this.cbDeleteColumn.TabIndex = 1;
            this.cbDeleteColumn.SelectedIndexChanged += new System.EventHandler(this.cbDeleteColumn_SelectedIndexChanged);
            // 
            // btDeleteColumn
            // 
            this.btDeleteColumn.Enabled = false;
            this.btDeleteColumn.Location = new System.Drawing.Point(535, 484);
            this.btDeleteColumn.Name = "btDeleteColumn";
            this.btDeleteColumn.Size = new System.Drawing.Size(75, 23);
            this.btDeleteColumn.TabIndex = 2;
            this.btDeleteColumn.Text = "Supprimer";
            this.btDeleteColumn.UseVisualStyleBackColor = true;
            this.btDeleteColumn.Click += new System.EventHandler(this.btDeleteColumn_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 489);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 3;
            // 
            // PreviewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 519);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btDeleteColumn);
            this.Controls.Add(this.cbDeleteColumn);
            this.Controls.Add(this.lblDeleteColumn);
            this.Controls.Add(this.dgvPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PreviewData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prévisualiser";
            this.Load += new System.EventHandler(this.PreviewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Label lblDeleteColumn;
        private System.Windows.Forms.ComboBox cbDeleteColumn;
        private System.Windows.Forms.Button btDeleteColumn;
        private System.Windows.Forms.Label lblCount;
    }
}