using System;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
            try
            {
                System.ComponentModel.BackgroundWorker bw = new System.ComponentModel.BackgroundWorker();
                bw.DoWork += new System.ComponentModel.DoWorkEventHandler(bw_DoWork);
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

        void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Library.MailerTools.Send();
        }

        private void SendPerSecondTimer_Tick(object sender, EventArgs e)
        {
            this.SendPerSecondValue.Text = this.SendPerSecondCounter.NextValue().ToString() + " email / seconde";
        }
    }
}
