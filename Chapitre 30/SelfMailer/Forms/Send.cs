using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Security.Permissions;

namespace SelfMailer.Forms
{
    [PrincipalPermission(SecurityAction.Demand, Role = "Administrateurs")]
    public partial class Send : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();

        public Send()
        {
            InitializeComponent();
            try
            {
                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                bw.WorkerReportsProgress = true;
                bw.WorkerSupportsCancellation = true;
                bw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    ex = ex.InnerException;
                }
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            bw.ReportProgress(0, "Envoi en cours");
            Library.MailerTools.Send();
        }
        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lblStatus.Text = e.UserState.ToString();
        }
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.lblStatus.Text = "Envoi terminé";
        }
        private void SendPerSecondTimer_Tick(object sender, EventArgs e)
        {
            this.SendPerSecondValue.Text = this.SendPerSecondCounter.NextValue().ToString() + " email / seconde";
        }
    }
}
