using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class ProjectSettings : Form
    {
        public ProjectSettings()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(Program.Project.ProjectSettings.Log))
                if (string.IsNullOrEmpty(Program.Project.Path))
                    this.Log.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetFileNameWithoutExtension(Program.Project.Filename) + ".txt");
                else
                    this.Log.Text = Path.Combine(Program.Project.Path, Path.GetFileNameWithoutExtension(Program.Project.Filename) + ".txt");
            else
                this.Log.Text = Program.Project.ProjectSettings.Log;

            this.SendDelay.Value = Program.Project.ProjectSettings.SendDelay;
            this.LanguageField.Items.Add("[Aucune langue]");

            if (Program.Project.Data != null)
            {
                foreach (DataColumn dc in Program.Project.Data.Columns)
                {
                    this.LanguageField.Items.Add(dc.ColumnName);
                    this.EmailField.Items.Add(dc.ColumnName);
                }
            }

            if (this.LanguageField.Items.Contains(Program.Project.ProjectSettings.LanguageField))
                this.LanguageField.SelectedItem = Program.Project.ProjectSettings.LanguageField;
            else if (this.LanguageField.Items.Count > 0)
                this.LanguageField.SelectedIndex = 0;

            if (this.EmailField.Items.Contains(Program.Project.ProjectSettings.EmailField))
                this.EmailField.SelectedItem = Program.Project.ProjectSettings.EmailField;
        }

        private void BrowseLog_Click(object sender, EventArgs e)
        {
            this.sfdLog.FileName = this.Log.Text;
            if (this.sfdLog.ShowDialog() == DialogResult.OK)
                this.Log.Text = this.sfdLog.FileName;
        }
        private void Valid_Click(object sender, EventArgs e)
        {
            Program.Project.ProjectSettings.Log = this.Log.Text;
            Program.Project.ProjectSettings.SendDelay = (int)this.SendDelay.Value;
            if (this.LanguageField.SelectedIndex >= 0)
                Program.Project.ProjectSettings.LanguageField = this.LanguageField.SelectedItem.ToString();
            else
                Program.Project.ProjectSettings.LanguageField = string.Empty;
            if (this.EmailField.SelectedIndex >= 0)
                Program.Project.ProjectSettings.EmailField = this.EmailField.SelectedItem.ToString();
            else
                Program.Project.ProjectSettings.EmailField = string.Empty;

            this.DialogResult = DialogResult.OK;
        }
    }
}
