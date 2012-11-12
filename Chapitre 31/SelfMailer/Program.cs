using System;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace SelfMailer
{
    static class Program
    {
        public static Library.Project Project;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Project = new Library.Project();
            if (args.Length == 1 &&
                   File.Exists(args[0]) &&
                   Path.GetExtension(args[0]) == ".smpx")
            {
                Project = Library.Project.Load(args[0]);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main());
        }
    }
}
