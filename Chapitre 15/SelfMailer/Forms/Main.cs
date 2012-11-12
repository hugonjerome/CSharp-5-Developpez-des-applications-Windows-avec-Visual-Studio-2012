using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Program.Project.Changed += new EventHandler<Library.ChangedEventArgs>(Project_Changed);
            this.InitUI();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Project.Save(true);
        }
        private void Project_Changed(object sender, Library.ChangedEventArgs e)
        {
            this.Text = "Self Mailer - " + Program.Project.Filename;
            if (Program.Project.HasChanged)
                this.Text += " *";
        }
        private void nouveauProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Project.Save(true);
            Program.Project = new Library.Project();
            Program.Project.Changed += new EventHandler<Library.ChangedEventArgs>(Project_Changed);
            for (int i = this.MainTab.TabPages.Count - 1; i >= 0; i--)
                this.MainTab.TabPages.RemoveAt(i);
            this.InitUI();
        }
        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Project.Save(true);
            if (this.ofdProject.ShowDialog() == DialogResult.OK)
            {
                Program.Project.Load(this.ofdProject.FileName);
                Program.Project.Changed += new EventHandler<Library.ChangedEventArgs>(Project_Changed);
                this.InitUI();
            }
        }
        private void sauverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Project.Save();
        }
        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Project.Save(false, true);
        }
        private void MailServerMenu_Click(object sender, EventArgs e)
        {
            new MailServerSettings().ShowDialog();
        }
        private void donnéeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.supprimerToolStripMenuItem.Enabled = Program.Project.Data.Rows.Count > 0;
            this.prévisualiserToolStripMenuItem.Enabled = Program.Project.Data.Rows.Count > 0;
        }
        private void chargerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ofdSource.Filter = "CSV (*.csv)|*.csv";
            if (this.ofdSource.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.Merge(Import(this.ofdSource.FileName, true, ';'));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'import:\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.RefreshTabs();
            }
        }
        private void prévisualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.PreviewData().ShowDialog();
            this.RefreshTabs();
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Toutes les données seront supprimées.\r\n\r\nSouhaitez vous continuer ?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Program.Project.Data.Columns.Clear();
                Program.Project.Data = new DataTable("datas");
                this.RefreshTabs();
            }
        }
        private void envoyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.Send().ShowDialog();
        }
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.About().ShowDialog();
        }
        private void projetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new Forms.ProjectSettings().ShowDialog() == DialogResult.OK)
                this.RefreshTabs();
        }
        private void TabPage_Enter(object sender, EventArgs e)
        {
            foreach (Control aControl in (sender as TabPage).Controls)
            {
                if (aControl is Controls.MailProperties)
                {
                    (aControl as Controls.MailProperties).RefreshProperties();
                }
            }
        }

        private void InitUI()
        {
            while (this.MainTab.TabPages.Count > 1)
                this.MainTab.TabPages.Remove(this.MainTab.TabPages[1]);

            this.Text = "Self Mailer - " + Program.Project.Filename;

            this.RefreshTabs();
            Program.Project.HasChanged = false;
        }
        private void RefreshTabs()
        {
            try
            {
                List<string> S = new List<string>();
                if (!string.IsNullOrEmpty(Program.Project.ProjectSettings.LanguageField)
                    && Program.Project.ProjectSettings.LanguageField != "[Aucune langue]"
                    && Program.Project.Data.Columns.Contains(Program.Project.ProjectSettings.LanguageField))
                {
                    for (int j = 0; j < Program.Project.Data.Rows.Count; j++)
                    {
                        string s = Program.Project.Data.Rows[j][Program.Project.ProjectSettings.LanguageField].ToString();
                        if (!S.Contains(s))
                            S.Add(s);
                    }
                    S.Sort();
                }
                S.Insert(0, "[aucune langue]");

                for (int i = this.MainTab.TabPages.Count - 1; i >= 0; i--)
                {
                    if (!S.Contains(this.MainTab.TabPages[i].Text))
                    {
                        Program.Project.MailProperties.Remove(this.MainTab.TabPages[i].Text);
                        this.MainTab.TabPages.RemoveAt(i);
                    }
                }
                foreach (string s in S)
                {
                    TabPage tp = TabPageExist(s);
                    if (tp == null)
                    {
                        tp = new TabPage(s);
                        tp.Enter += new EventHandler(TabPage_Enter);
                        Controls.MailProperties MP = new Controls.MailProperties();
                        MP.Name = s;
                        MP.Dock = DockStyle.Fill;
                        tp.Controls.Add(MP);
                        this.MainTab.TabPages.Add(tp);
                    }
                    else
                    {
                        (tp.Controls[0] as Controls.MailProperties).RetrieveValues(s);
                    }
                }
                TabPage_Enter(this.MainTab.TabPages[0], null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est apparu lors du chargement des onglets de langue.\r\n\r\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private TabPage TabPageExist(string tabText)
        {
            foreach (TabPage aPage in this.MainTab.TabPages)
                if (aPage.Text == tabText)
                    return aPage;
            return null;
        }
        private DataTable Import(string file, bool WithTitle, char Separator)
        {
            DataTable Result = new DataTable("datas");
            if (File.Exists(file))
            {
                StreamReader StreamCSV = new StreamReader(file, Encoding.Default);
                string aLine = StreamCSV.ReadLine();
                if (aLine != null)
                {
                    string[] Columns = aLine.Split(new char[] { Separator });
                    foreach (string aColumn in Columns)
                        if (WithTitle)
                            Result.Columns.Add(aColumn);
                        else
                            Result.Columns.Add();

                    DataRow aRow = Result.NewRow();
                    if (!WithTitle && Result.Columns.Count == Columns.Length)
                    {
                        for (int i = 0; i < Result.Columns.Count; i++)
                            aRow[i] = Columns[i];
                        Result.Rows.Add(aRow);
                    }

                    aLine = StreamCSV.ReadLine();
                    while (aLine != null)
                    {
                        Columns = aLine.Split(new char[] { Separator });
                        if (Result.Columns.Count == Columns.Length)
                        {
                            aRow = Result.NewRow();
                            for (int i = 0; i < Result.Columns.Count; i++)
                                aRow[i] = Columns[i];
                            Result.Rows.Add(aRow);
                        }
                        aLine = StreamCSV.ReadLine();
                    }
                }
                StreamCSV.Close();
            }
            return CleanTable(Result);
        }
        public DataTable CleanTable(DataTable TableToClean)
        {
            List<DataRow> RowToDelete = new List<DataRow>();
            List<string> ColumnNameToDelete = new List<string>();
            for (int i = 0; i < TableToClean.Columns.Count; i++)
                ColumnNameToDelete.Add(TableToClean.Columns[i].ColumnName);

            foreach (DataRow aRow in TableToClean.Rows)
            {
                bool DeleteRow = true;
                for (int i = 0; i < TableToClean.Columns.Count; i++)
                    if (aRow[i] != null)
                        if (aRow[i].ToString() != "")
                        {
                            ColumnNameToDelete.Remove(TableToClean.Columns[i].ColumnName);
                            DeleteRow = false;
                        }
                if (DeleteRow)
                    RowToDelete.Add(aRow);
            }
            foreach (DataRow aRow in RowToDelete)
                TableToClean.Rows.Remove(aRow);
            foreach (string s in ColumnNameToDelete)
                TableToClean.Columns.Remove(s);

            return TableToClean;
        }
        private void Merge(DataTable newData)
        {
            if (Program.Project.Data.Columns.Count > 0
                && MessageBox.Show("Des données sont déjà chargées, souhaitez-vous les remplacer ?\r\nOui pour remplacer toutes les données\r\nNon pour fusionner les données", "Replacer ou Fusionner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                Program.Project.Data.Columns.Clear();
                Program.Project.Data = new DataTable();
            }
            if (Program.Project.Data.Columns.Count == 0)
                Program.Project.Data = newData;
            else
            {
                DataTable currentData = Program.Project.Data;
                foreach (DataColumn dc in newData.Columns)
                    if (!currentData.Columns.Contains(dc.ColumnName))
                        currentData.Columns.Add(dc.ColumnName);
                foreach (DataRow newRow in newData.Rows)
                {
                    DataRow aRow = currentData.NewRow();
                    for (int i = 0; i < currentData.Columns.Count; i++)
                        if (newData.Columns.Contains(currentData.Columns[i].ColumnName))
                            aRow[i] = newRow[currentData.Columns[i].ColumnName];
                    currentData.Rows.Add(aRow);
                }
                Program.Project.Data = currentData;
            }
        }
    }
}
