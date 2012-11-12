using System;
using System.Data.Objects;
using System.Linq;
using System.Windows.Forms;
using SelfMailer.Entities;
using SelfMailer.Library;

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

            this.LoadConfigurations();
        }

        private void LoadConfigurations()
        {
            using (SelfMailerContainer entities = new SelfMailerContainer())
            {
                ObjectQuery<MailServer> query = entities.MailServers.OrderBy("it.Host");
                foreach (MailServer mailServer in query)
                {
                    foreach (Sender sender in mailServer.Sender)
                    {
                        this.ConfigList.Items.Add(new ComboBoxItem(mailServer.EntityKey, sender.EntityKey, mailServer.Host + " - " + sender.Name));
                    }
                }
            }
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

        private void ConfigList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem result = this.ConfigList.SelectedItem as ComboBoxItem;
            using (SelfMailerContainer entities = new SelfMailerContainer())
            {
                MailServer mailServers = entities.GetObjectByKey(result.MailServerKey) as MailServer;
                Sender senders = entities.GetObjectByKey(result.SenderKey) as Sender;
                this.FromName.Text = senders.Name;
                this.FromEmail.Text = senders.Email;
                this.Host.Text = mailServers.Host;
                this.Username.Text = mailServers.Username;
                if (mailServers.Password.AllowSave)
                {
                    this.Password.Text = mailServers.Password.Value;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Host.Text))
                this.errorProvider.SetError(this.Host, "Le champ Hôte doit être complété.");
            else if (this.ValidateChildren())
            {
                using (var entities = new SelfMailerContainer())
                {
                    MailServer newMailServer;
                    Sender newSender;
                    if (this.ConfigList.SelectedIndex >= 0)
                    {
                        ComboBoxItem selected = this.ConfigList.SelectedItem as ComboBoxItem;
                        newMailServer = entities.GetObjectByKey(selected.MailServerKey) as MailServer;
                        newSender = entities.GetObjectByKey(selected.SenderKey) as Sender;
                    }
                    else
                    {
                        newMailServer = entities.MailServers.Where("it.Host = @Host && it.Username = @Username && it.Password.Value = @PasswordValue"
                            , new ObjectParameter("Host", this.Host.Text)
                            , new ObjectParameter("Username", this.Username.Text)
                            , new ObjectParameter("PasswordValue", this.Password.Text)).FirstOrDefault<MailServer>();
                        if (newMailServer == null)
                        {
                            newMailServer = new MailServer();
                            entities.AddToMailServers(newMailServer);
                        }

                        newSender = entities.Senders.Where("it.Name = @Name && it.Email = @Email"
                           , new ObjectParameter("Name", this.FromName.Text)
                           , new ObjectParameter("Email", this.FromEmail.Text)).FirstOrDefault<Sender>();
                        if (newSender == null)
                        {
                            newSender = new Sender();
                            entities.AddToSenders(newSender);
                        }

                        if (!newSender.MailServer.Contains(newMailServer))
                        {
                            newSender.MailServer.Add(newMailServer);
                        }
                    }

                    newMailServer.Host = this.Host.Text;
                    newMailServer.Username = this.Username.Text;
                    newMailServer.Password.Value = this.Password.Text;
                    newMailServer.Password.AllowSave = true;

                    newSender.Name = this.FromName.Text;
                    newSender.Email = this.FromEmail.Text;

                    entities.SaveChanges();
                }
            }
            MessageBox.Show("La configuration a été enregistrée.");
            this.LoadConfigurations();
        }
    }
}
