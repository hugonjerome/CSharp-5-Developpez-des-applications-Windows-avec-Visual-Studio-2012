using System;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class LoadBody : Form
    {
        public string MailBody
        {
            get { return this.Body.Text; }
        }
        
        public LoadBody()
        {
            InitializeComponent();
        }

        private void Valid_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            if (this.ofdMailBody.ShowDialog() == DialogResult.OK)
                this.Body.Text = this.ofdMailBody.FileName;
        }
    }
}
