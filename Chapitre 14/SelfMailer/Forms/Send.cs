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
                Library.MailerTools.Send();
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
    }
}
