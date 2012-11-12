namespace SelfMailer.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prévisualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParametersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MailServerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.projetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.ofdProject = new System.Windows.Forms.OpenFileDialog();
            this.ofdSource = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.donnéeToolStripMenuItem,
            this.ParametersMenu,
            this.envoyerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MainMenu.Name = "MainMenu";
            // 
            // fichierToolStripMenuItem
            // 
            resources.ApplyResources(this.fichierToolStripMenuItem, "fichierToolStripMenuItem");
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauProjetToolStripMenuItem,
            this.chargerToolStripMenuItem,
            this.sauverToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            // 
            // nouveauProjetToolStripMenuItem
            // 
            resources.ApplyResources(this.nouveauProjetToolStripMenuItem, "nouveauProjetToolStripMenuItem");
            this.nouveauProjetToolStripMenuItem.Name = "nouveauProjetToolStripMenuItem";
            this.nouveauProjetToolStripMenuItem.Click += new System.EventHandler(this.nouveauProjetToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            resources.ApplyResources(this.chargerToolStripMenuItem, "chargerToolStripMenuItem");
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // sauverToolStripMenuItem
            // 
            resources.ApplyResources(this.sauverToolStripMenuItem, "sauverToolStripMenuItem");
            this.sauverToolStripMenuItem.Name = "sauverToolStripMenuItem";
            this.sauverToolStripMenuItem.Click += new System.EventHandler(this.sauverToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            resources.ApplyResources(this.enregistrerSousToolStripMenuItem, "enregistrerSousToolStripMenuItem");
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // donnéeToolStripMenuItem
            // 
            resources.ApplyResources(this.donnéeToolStripMenuItem, "donnéeToolStripMenuItem");
            this.donnéeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem1,
            this.prévisualiserToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.donnéeToolStripMenuItem.Name = "donnéeToolStripMenuItem";
            this.donnéeToolStripMenuItem.DropDownOpening += new System.EventHandler(this.donnéeToolStripMenuItem_DropDownOpening);
            // 
            // chargerToolStripMenuItem1
            // 
            resources.ApplyResources(this.chargerToolStripMenuItem1, "chargerToolStripMenuItem1");
            this.chargerToolStripMenuItem1.Name = "chargerToolStripMenuItem1";
            this.chargerToolStripMenuItem1.Click += new System.EventHandler(this.chargerToolStripMenuItem1_Click);
            // 
            // prévisualiserToolStripMenuItem
            // 
            resources.ApplyResources(this.prévisualiserToolStripMenuItem, "prévisualiserToolStripMenuItem");
            this.prévisualiserToolStripMenuItem.Name = "prévisualiserToolStripMenuItem";
            this.prévisualiserToolStripMenuItem.Click += new System.EventHandler(this.prévisualiserToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            resources.ApplyResources(this.supprimerToolStripMenuItem, "supprimerToolStripMenuItem");
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ParametersMenu
            // 
            resources.ApplyResources(this.ParametersMenu, "ParametersMenu");
            this.ParametersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MailServerMenu,
            this.projetToolStripMenuItem});
            this.ParametersMenu.Name = "ParametersMenu";
            // 
            // MailServerMenu
            // 
            resources.ApplyResources(this.MailServerMenu, "MailServerMenu");
            this.MailServerMenu.Name = "MailServerMenu";
            this.MailServerMenu.Click += new System.EventHandler(this.MailServerMenu_Click);
            // 
            // projetToolStripMenuItem
            // 
            resources.ApplyResources(this.projetToolStripMenuItem, "projetToolStripMenuItem");
            this.projetToolStripMenuItem.Name = "projetToolStripMenuItem";
            this.projetToolStripMenuItem.Click += new System.EventHandler(this.projetToolStripMenuItem_Click);
            // 
            // envoyerToolStripMenuItem
            // 
            resources.ApplyResources(this.envoyerToolStripMenuItem, "envoyerToolStripMenuItem");
            this.envoyerToolStripMenuItem.Name = "envoyerToolStripMenuItem";
            this.envoyerToolStripMenuItem.Click += new System.EventHandler(this.envoyerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // aProposToolStripMenuItem
            // 
            resources.ApplyResources(this.aProposToolStripMenuItem, "aProposToolStripMenuItem");
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // MainTab
            // 
            resources.ApplyResources(this.MainTab, "MainTab");
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            // 
            // ofdProject
            // 
            this.ofdProject.FileName = "sans titre.smpx";
            resources.ApplyResources(this.ofdProject, "ofdProject");
            this.ofdProject.RestoreDirectory = true;
            this.ofdProject.SupportMultiDottedExtensions = true;
            // 
            // ofdSource
            // 
            resources.ApplyResources(this.ofdSource, "ofdSource");
            this.ofdSource.RestoreDirectory = true;
            this.ofdSource.SupportMultiDottedExtensions = true;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ParametersMenu;
        private System.Windows.Forms.ToolStripMenuItem MailServerMenu;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdProject;
        private System.Windows.Forms.ToolStripMenuItem donnéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prévisualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdSource;
    }
}