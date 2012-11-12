using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SelfMailer.Library
{
    public class Project : IReportChildrenChange
    {
        protected string filename = "sans titre.smpx", path;
        protected bool hasChanged;
        protected DataTable data = new DataTable();

        public string Filename
        {
            get { return filename; }
            protected set
            {
                if (this.filename != value)
                {
                    this.filename = value;
                    this.HasChanged = true;
                }
            }
        }
        public string Path
        {
            get { return path; }
            protected set
            {
                if (this.path != value)
                {
                    this.path = value;
                    this.HasChanged = true;
                }
            }
        }
        public DataTable Data
        {
            get { return data; }
            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.HasChanged = true;
                }
            }
        }
        public bool HasChanged
        {
            get { return hasChanged; }
            set { hasChanged = value; }
        }
        public ProjectSettings ProjectSettings { get; set; }
        public MailServerSettings MailServerSettings { get; set; }

        public event EventHandler Changed;

        public Project()
        {
            this.ProjectSettings = new ProjectSettings();
            this.ProjectSettings.Changed += new EventHandler(ChildChanged);
            this.MailServerSettings = new MailServerSettings();
            this.MailServerSettings.Changed += new EventHandler(ChildChanged);
        }

        /// <summary>
        /// Sauvegarde le projet.
        /// </summary>
        /// <param name="Ask">Spécifie si l'utilisateur doit confirmer la sauvegarde.</param>
        /// <param name="ShowDialog">Spécifie si l'utilisateur a la possibilité de choisir le fichier.</param>
        public void Save(bool Ask = false, bool ShowDialog = false)
        {
            /* Si l'utilisateur doit confirmer la sauvegarde et que le projet à été modifié,
             * l'utilisateur doit cliquer sur le bouton Oui de la boîte de dialogue */
            if (!Ask || (this.HasChanged && MessageBox.Show("Voulez-vous sauvegarder les modifications ?", "Sauver", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes))
            {
                /* Si l'utilisateur n'a pas la possibilité de choisir un fichier
                 * et que le nom du fichier ainsi que son chemin sont définis,
                 * le projet est enregistré et la propriété HasChanged est réinitialisée */
                if (!ShowDialog && !string.IsNullOrEmpty(this.Filename) && !string.IsNullOrEmpty(this.Path))
                {
                    // Sauvegarde des données non implémentée
                    this.HasChanged = false;
                }
                /* Dans le cas contraire l'utilisateur doit choisir un chemin et
                 * un nom de fichier pour le projet qui sera enregistré */
                else
                {
                    // Instanciation et initialisation de la boîte de dialogue de sauvegarde de fichiers
                    SaveFileDialog sfdProject = new SaveFileDialog();
                    sfdProject.Filter = "Projet Self Mailer (*.smpx)|*.smpx";
                    sfdProject.RestoreDirectory = true;
                    sfdProject.SupportMultiDottedExtensions = true;
                    sfdProject.Title = "Sauver le projet";
                    // Affichage de la boîte de dialogue et test de la valeur de retour
                    if (sfdProject.ShowDialog() == DialogResult.OK)
                    {
                        // Assignation des valeurs aux variables et sauvegarde du projet
                        this.Filename = System.IO.Path.GetFileName(sfdProject.FileName);
                        this.Path = System.IO.Path.GetDirectoryName(sfdProject.FileName);
                        // Sauvegarde des données non implémentée
                        this.HasChanged = false;
                    }
                }
            }
        }

        public void ChildChanged(object sender, EventArgs e)
        {
            if (sender is IReportChange)
            {
                IReportChange Child = (IReportChange)sender;
                this.HasChanged = Child.HasChanged;
            }
        }
    }
}
