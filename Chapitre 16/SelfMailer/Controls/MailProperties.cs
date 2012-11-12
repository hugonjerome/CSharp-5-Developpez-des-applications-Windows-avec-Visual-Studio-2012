using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SelfMailer.Controls
{
    public partial class MailProperties : UserControl
    {
        public MailProperties()
        {
            InitializeComponent();
        }

        private void MailProperties_Load(object sender, EventArgs e)
        {
            this.InitSendType();
            if (Program.Project.MailProperties[this.Name] != null)
            {
                if (!this.SendType.Items.Contains(Program.Project.MailProperties[this.Name].SendType))
                    this.SendType.SelectedItem = Program.Project.MailProperties[this.Name].SendType;
                this.Subject.Text = Program.Project.MailProperties[this.Name].Subject;
            }
            else
            {
                Program.Project.MailProperties.Add(new Library.MailProperties() { Name = this.Name, HasChanged = false });
            }
        }
        private void SendType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SendType.SelectedIndex == 1)
            {
                this.MailContent.Enabled = true;
            }
            else if (this.SendType.SelectedIndex > 1)
            {
                this.RetrieveValues(this.SendType.SelectedItem.ToString());
            }
            else
            {
                this.MailContent.Enabled = false;
            }
            if (Program.Project.MailProperties[this.Name] != null)
            {
                Program.Project.MailProperties[this.Name].SendType = this.SendType.SelectedItem.ToString();
            }
        }
        private void Subject_TextChanged(object sender, EventArgs e)
        {
            Program.Project.MailProperties[this.Name].Subject = this.Subject.Text;
        }
        private void LoadBody_Click(object sender, EventArgs e)
        {
            Forms.LoadBody loadBody = new Forms.LoadBody();
            if (loadBody.ShowDialog() == DialogResult.OK)
            {
                string newBody = string.Empty;
                if (!string.IsNullOrEmpty(loadBody.MailBody))
                    try
                    {
                        if (Uri.IsWellFormedUriString(loadBody.MailBody, UriKind.Absolute))
                        {
                            newBody = this.GetHtmlPage(loadBody.MailBody);
                        }
                        else
                        {
                            newBody = System.IO.File.ReadAllText(loadBody.MailBody);
                        }
                        Program.Project.MailProperties[this.Name].Body = newBody;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occur:\r\n\r\n" + ex.Message + "\r\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.LoadBody_Click(sender, e);
                    }
            }
            this.PreviewBody.Enabled = !string.IsNullOrEmpty(Program.Project.MailProperties[this.Name].Body);
        }
        private void PreviewBody_Click(object sender, EventArgs e)
        {
            new Forms.PreviewBody(Program.Project.MailProperties[this.Name].Body).ShowDialog();
        }

        private void InitSendType()
        {
            if (!this.SendType.Items.Contains("Ne pas envoyer"))
                this.SendType.Items.Add("Ne pas envoyer");
            if (!this.SendType.Items.Contains("Envoi personnalisé"))
                this.SendType.Items.Add("Envoi personnalisé");
            foreach (Library.MailProperties aProperty in Program.Project.MailProperties)
                if (aProperty.Name != this.Name && !this.SendType.Items.Contains(aProperty.Name))
                    this.SendType.Items.Add(aProperty.Name);
            for (int i = this.SendType.Items.Count - 1; i > 1; i--)
                if (Program.Project.MailProperties[this.SendType.Items[i].ToString()] == null)
                    this.SendType.Items.RemoveAt(i);

            if (Program.Project.MailProperties[this.Name] != null
                && Program.Project.MailProperties[this.Name].SendType != null
                && this.SendType.Items.Contains(Program.Project.MailProperties[this.Name].SendType))
                this.SendType.SelectedItem = Program.Project.MailProperties[this.Name].SendType;
            else
                this.SendType.SelectedIndex = 0;
        }
        public void RefreshProperties()
        {
            this.InitSendType();
            if (this.SendType.SelectedIndex > 1)
            {
                this.RetrieveValues(this.SendType.SelectedItem.ToString());
            }
        }
        public void RetrieveValues(string from)
        {
            this.MailContent.Enabled = false;
            Program.Project.MailProperties[this.Name].Subject = Program.Project.MailProperties[from].Subject;
            Program.Project.MailProperties[this.Name].Body = Program.Project.MailProperties[from].Body;
            this.Subject.Text = Program.Project.MailProperties[this.Name].Subject;
        }
        private string GetHtmlPage(string url)
        {
            try
            {
                WebRequest objRequest = HttpWebRequest.Create(url);
                StreamReader sr = new StreamReader(objRequest.GetResponse().GetResponseStream());
                string result = sr.ReadToEnd();
                sr.Close();
                return result;
            }
            catch
            {
                return "";
            }
        }
    }
}
