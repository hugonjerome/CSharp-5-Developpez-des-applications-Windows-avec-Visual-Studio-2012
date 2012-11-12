using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;

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

        private void FromEmail_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                             @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
                             @"(([a-zA-Z0-9\-]+\.)+))" +
                             @"([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(this.FromEmail.Text))
            {
                this.errorProvider.SetError(this.FromEmail, "Le format de l'email est incorrect.");
                e.Cancel = true;
            }
        }
    }
}
