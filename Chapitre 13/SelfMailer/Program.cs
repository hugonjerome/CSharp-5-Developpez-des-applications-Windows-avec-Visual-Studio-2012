using System;
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
        static void Main()
        {
            Project = new Library.Project();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main());
        }
    }
}
