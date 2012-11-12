using System;
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
        static void Main()
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal currentUser = Thread.CurrentPrincipal as WindowsPrincipal;
            MessageBox.Show("Bonjour " + currentUser.Identity.Name);

            Project = new Library.Project();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.ChooseCulture());
            Application.Run(new Forms.Main());
        }
    }
}
