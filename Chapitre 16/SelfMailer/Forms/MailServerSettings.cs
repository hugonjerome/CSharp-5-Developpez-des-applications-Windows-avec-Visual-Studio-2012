using System;
using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class MailServerSettings : Form
    {
        public MailServerSettings()
        {
            InitializeComponent();
            this.FromName.Text = Program.Project.MailServerSettings.FromName;
            this.FromEmail.Text = Program.Project.MailServerSettings.FromEmail;
            this.Host.Text = Program.Project.MailServerSettings.Host;
            this.Username.Text = Program.Project.MailServerSettings.Username;
            this.Password.Text = Program.Project.MailServerSettings.Password;
        }

        private void Valid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Host.Text))
                this.errorProvider.SetError(this.Host, "Le champ Hôte doit être complété.");
            else if (this.ValidateChildren())
            {
                Program.Project.MailServerSettings.FromName = this.FromName.Text;
                Program.Project.MailServerSettings.FromEmail = this.FromEmail.Text;
                Program.Project.MailServerSettings.Host = this.Host.Text;
                Program.Project.MailServerSettings.Username = this.Username.Text;
                Program.Project.MailServerSettings.Password = this.Password.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
