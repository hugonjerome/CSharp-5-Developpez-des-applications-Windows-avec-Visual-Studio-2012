using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using SelfMailer.LinqToSql;
using SelfMailer.Library;
using System.Collections.Generic;

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
            using (SelfMailerDataContext context = new SelfMailerDataContext())
            {
                IEnumerable<MailServers> query1 = context.ExecuteQuery<MailServers>("SELECT * FROM MailServers ORDER BY Host");
                foreach (MailServers mailServer in query1)
                {
                    IEnumerable<Senders> query2 = context.ExecuteQuery<Senders>("SELECT S.* FROM Senders AS S INNER JOIN MailServerSender AS MSS ON S.ID = MSS.Sender_ID WHERE MSS.MailServer_ID = {0}", mailServer.ID);
                    foreach (Senders sender in query2)
                    {
                        this.ConfigList.Items.Add(new ComboBoxItem(mailServer.ID, sender.ID, mailServer.Host + " - " + sender.Name));
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
            using (SelfMailerDataContext context = new SelfMailerDataContext())
            {
                MailServers mailServers = context.MailServers.Single<MailServers>(x => x.ID == result.MailServerKey);
                Senders senders = context.Senders.Single<Senders>(x => x.ID == result.SenderKey);
                this.FromName.Text = senders.Name;
                this.FromEmail.Text = senders.Email;
                this.Host.Text = mailServers.Host;
                this.Username.Text = mailServers.Username;
                if (mailServers.Password_AllowSave)
                {
                    this.Password.Text = mailServers.Password_Value;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Host.Text))
                this.errorProvider.SetError(this.Host, "Le champ Hôte doit être complété.");
            else if (this.ValidateChildren())
            {
                using (SelfMailerDataContext context = new SelfMailerDataContext())
                {
                    MailServers newMailServer;
                    Senders newSender;
                    if (this.ConfigList.SelectedIndex >= 0)
                    {
                        ComboBoxItem selected = this.ConfigList.SelectedItem as ComboBoxItem;
                        newMailServer = context.MailServers.Single<MailServers>(x => x.ID == selected.MailServerKey);
                        newSender = context.Senders.Single<Senders>(x => x.ID == selected.SenderKey);
                    }
                    else
                    {
                        newMailServer = context.MailServers.SingleOrDefault<MailServers>(x => x.Host == this.Host.Text && x.Username == this.Username.Text && x.Password_Value == this.Password.Text);
                        if (newMailServer == null)
                        {
                            newMailServer = new MailServers();
                            context.MailServers.InsertOnSubmit(newMailServer);
                        }

                        newSender = context.Senders.SingleOrDefault<Senders>(x => x.Name == this.FromName.Text && x.Email == this.FromEmail.Text);
                        if (newSender == null)
                        {
                            newSender = new Senders();
                            context.Senders.InsertOnSubmit(newSender);
                        }
                    }

                    newMailServer.Host = this.Host.Text;
                    newMailServer.Username = this.Username.Text;
                    newMailServer.Password_Value = this.Password.Text;
                    newMailServer.Password_AllowSave = true;

                    newSender.Name = this.FromName.Text;
                    newSender.Email = this.FromEmail.Text;

                    context.SubmitChanges();

                    MailServerSender rel = context.MailServerSender.SingleOrDefault<MailServerSender>(x => x.MailServer_ID == newMailServer.ID && x.Sender_ID == newSender.ID);
                    if (rel == null)
                    {
                        rel = new MailServerSender();
                        rel.MailServer_ID = newMailServer.ID;
                        rel.Sender_ID = newSender.ID;
                        context.MailServerSender.InsertOnSubmit(rel);
                    }
                    context.SubmitChanges();
                }
            }
            MessageBox.Show("La configuration a été enregistrée.");
            this.LoadConfigurations();
        }
    }
}
