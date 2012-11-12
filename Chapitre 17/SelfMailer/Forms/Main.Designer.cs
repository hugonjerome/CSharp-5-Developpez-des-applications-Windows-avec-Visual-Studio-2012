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
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.donnéeToolStripMenuItem,
            this.ParametersMenu,
            this.envoyerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(552, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauProjetToolStripMenuItem,
            this.chargerToolStripMenuItem,
            this.sauverToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // nouveauProjetToolStripMenuItem
            // 
            this.nouveauProjetToolStripMenuItem.Name = "nouveauProjetToolStripMenuItem";
            this.nouveauProjetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauProjetToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.nouveauProjetToolStripMenuItem.Text = "&Nouveau";
            this.nouveauProjetToolStripMenuItem.Click += new System.EventHandler(this.nouveauProjetToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.chargerToolStripMenuItem.Text = "&Charger ...";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // sauverToolStripMenuItem
            // 
            this.sauverToolStripMenuItem.Name = "sauverToolStripMenuItem";
            this.sauverToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauverToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.sauverToolStripMenuItem.Text = "&Enregistrer";
            this.sauverToolStripMenuItem.Click += new System.EventHandler(this.sauverToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.enregistrerSousToolStripMenuItem.Text = "En&registrer sous ...";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // donnéeToolStripMenuItem
            // 
            this.donnéeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem1,
            this.prévisualiserToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.donnéeToolStripMenuItem.Name = "donnéeToolStripMenuItem";
            this.donnéeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.donnéeToolStripMenuItem.Text = "&Données";
            this.donnéeToolStripMenuItem.DropDownOpening += new System.EventHandler(this.donnéeToolStripMenuItem_DropDownOpening);
            // 
            // chargerToolStripMenuItem1
            // 
            this.chargerToolStripMenuItem1.Name = "chargerToolStripMenuItem1";
            this.chargerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.chargerToolStripMenuItem1.Text = "&Charger ...";
            this.chargerToolStripMenuItem1.Click += new System.EventHandler(this.chargerToolStripMenuItem1_Click);
            // 
            // prévisualiserToolStripMenuItem
            // 
            this.prévisualiserToolStripMenuItem.Name = "prévisualiserToolStripMenuItem";
            this.prévisualiserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prévisualiserToolStripMenuItem.Text = "&Prévisualiser";
            this.prévisualiserToolStripMenuItem.Click += new System.EventHandler(this.prévisualiserToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "&Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ParametersMenu
            // 
            this.ParametersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MailServerMenu,
            this.projetToolStripMenuItem});
            this.ParametersMenu.Name = "ParametersMenu";
            this.ParametersMenu.Size = new System.Drawing.Size(78, 20);
            this.ParametersMenu.Text = "&Paramètres";
            // 
            // MailServerMenu
            // 
            this.MailServerMenu.Name = "MailServerMenu";
            this.MailServerMenu.ShortcutKeyDisplayString = "";
            this.MailServerMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MailServerMenu.Size = new System.Drawing.Size(184, 22);
            this.MailServerMenu.Text = "Serveur &Mail";
            this.MailServerMenu.Click += new System.EventHandler(this.MailServerMenu_Click);
            // 
            // projetToolStripMenuItem
            // 
            this.projetToolStripMenuItem.Name = "projetToolStripMenuItem";
            this.projetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.projetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.projetToolStripMenuItem.Text = "&Projet";
            this.projetToolStripMenuItem.Click += new System.EventHandler(this.projetToolStripMenuItem_Click);
            // 
            // envoyerToolStripMenuItem
            // 
            this.envoyerToolStripMenuItem.Name = "envoyerToolStripMenuItem";
            this.envoyerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.envoyerToolStripMenuItem.Text = "Envoyer";
            this.envoyerToolStripMenuItem.Click += new System.EventHandler(this.envoyerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aProposToolStripMenuItem.Text = "&À propos de ...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // MainTab
            // 
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 24);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(552, 141);
            this.MainTab.TabIndex = 1;
            // 
            // ofdProject
            // 
            this.ofdProject.FileName = "sans titre.smpx";
            this.ofdProject.Filter = "Self Mailer Project (*.smpx)|*.smpx";
            this.ofdProject.RestoreDirectory = true;
            this.ofdProject.SupportMultiDottedExtensions = true;
            this.ofdProject.Title = "Charger un projet";
            // 
            // ofdSource
            // 
            this.ofdSource.RestoreDirectory = true;
            this.ofdSource.SupportMultiDottedExtensions = true;
            this.ofdSource.Title = "Load source file";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 165);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Main";
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