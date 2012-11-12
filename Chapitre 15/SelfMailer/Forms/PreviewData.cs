using System;
using System.Data;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class PreviewData : Form
    {
        public PreviewData()
        {
            InitializeComponent();
            this.InitUI();
        }
        private void PreviewData_Load(object sender, EventArgs e)
        {
            this.dgvPreview.CellValueChanged += new DataGridViewCellEventHandler(this.dgvPreview_CellValueChanged);
            this.dgvPreview.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvPreview_RowsAdded);
            this.dgvPreview.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgvPreview_RowsRemoved);
        }
        private void dgvPreview_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Program.Project.HasChanged = true;
            this.lblCount.Text = (this.dgvPreview.Rows.Count - 1).ToString() + " enregistrements";
        }
        private void dgvPreview_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Program.Project.HasChanged = true;
            this.lblCount.Text = (this.dgvPreview.Rows.Count - 1).ToString() + " enregistrements";
        }
        private void dgvPreview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Program.Project.HasChanged = true;
        }
        private void cbDeleteColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btDeleteColumn.Enabled = this.cbDeleteColumn.SelectedIndex >= 0;
        }
        private void btDeleteColumn_Click(object sender, EventArgs e)
        {
            if (this.cbDeleteColumn.SelectedIndex >= 0)
                Program.Project.Data.Columns.RemoveAt(this.cbDeleteColumn.SelectedIndex);
            this.InitUI();
        }
        private void InitUI()
        {
            this.dgvPreview.DataSource = Program.Project.Data;
            this.lblCount.Text = (this.dgvPreview.Rows.Count - 1).ToString() + " enregistrements";
            this.cbDeleteColumn.Items.Clear();
            foreach (DataColumn dc in Program.Project.Data.Columns)
                this.cbDeleteColumn.Items.Add(dc.ColumnName);
            this.cbDeleteColumn.Enabled = this.cbDeleteColumn.Items.Count > 0;
            this.btDeleteColumn.Enabled = this.cbDeleteColumn.Items.Count > 0 && this.cbDeleteColumn.SelectedIndex >= 0; ;
        }
    }
}
