using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SelfMailer.Library
{
    public class Project : IReportChildrenChange
    {
        protected string filename = "sans titre.smpx", path;
        protected bool hasChanged;
        protected DataTable data = new DataTable("datas");

        [XmlIgnore]
        public string Filename
        {
            get { return filename; }
            set
            {
                if (this.filename != value)
                {
                    this.filename = value;
                    this.HasChanged = true;
                }
            }
        }
        [XmlIgnore]
        public string Path
        {
            get { return path; }
            set
            {
                if (this.path != value)
                {
                    this.path = value;
                    this.HasChanged = true;
                }
            }
        }
        [XmlIgnore]
        public bool HasChanged
        {
            get
            {
                return this.hasChanged
                    || this.MailProperties.HasChanged
                    || this.ProjectSettings.HasChanged
                    || this.MailServerSettings.HasChanged;
            }
            set
            {
                if (this.HasChanged != value)
                {
                    this.hasChanged = value;
                    if (this.Changed != null)
                        this.Changed(this, new ChangedEventArgs(this.HasChanged));
                }
                if (!value)
                {
                    this.MailProperties.HasChanged = value;
                    this.ProjectSettings.HasChanged = value;
                    this.MailServerSettings.HasChanged = value;
                }
            }
        }
        public ProjectSettings ProjectSettings { get; set; }
        public MailServerSettings MailServerSettings { get; set; }
        public ReportChangeList<MailProperties> MailProperties { get; set; }
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

        public event EventHandler<ChangedEventArgs> Changed;

        public Project()
        {
            this.ProjectSettings = new ProjectSettings();
            this.ProjectSettings.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
            this.MailServerSettings = new MailServerSettings();
            this.MailServerSettings.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
            this.MailProperties = new ReportChangeList<MailProperties>();
            this.MailProperties.Changed += new EventHandler<ChangedEventArgs>(ChildChanged);
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
                    Serializer<Project>.Serialize(this, System.IO.Path.Combine(this.Path, this.Filename));
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
                        Serializer<Project>.Serialize(this, System.IO.Path.Combine(this.Path, this.Filename));
                        this.HasChanged = false;
                    }
                }
            }
        }
        public static Project Load(string FilePath)
        {
            Project result = Serializer<Project>.Deserialize(FilePath);
            result.Path = System.IO.Path.GetDirectoryName(FilePath);
            result.Filename = System.IO.Path.GetFileName(FilePath);
            result.HasChanged = false;
            result.ProjectSettings.Changed += new EventHandler<ChangedEventArgs>(result.ChildChanged);
            result.MailServerSettings.Changed += new EventHandler<ChangedEventArgs>(result.ChildChanged);
            result.MailProperties.Changed += new EventHandler<ChangedEventArgs>(result.ChildChanged);
            return result;
        }

        public void ChildChanged(object sender, ChangedEventArgs e)
        {
            if (this.Changed != null)
                this.Changed(sender, e);
        }
    }
}
