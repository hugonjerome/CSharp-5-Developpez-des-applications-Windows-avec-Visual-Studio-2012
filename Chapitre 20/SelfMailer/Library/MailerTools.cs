using System;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace SelfMailer.Library
{
    public class ComboBoxItem
    {
        public EntityKey MailServerKey { get; set; }
        public EntityKey SenderKey { get; set; }
        public string Text { get; set; }
        public ComboBoxItem(EntityKey mailServerKey, EntityKey senderKey, string text)
        {
            this.MailServerKey = mailServerKey;
            this.SenderKey = senderKey;
            this.Text = text;
        }
        public override string ToString()
        {
            return this.Text;
        }
    }
    public static class MailerTools
    {
        private static PerformanceCounter SendPerSecondCounter = new PerformanceCounter("SelfMailer", "SendPerSecond", false);
        
        public static void Send()
        {
            try
            {
                foreach (MailProperties aMailProperties in Program.Project.MailProperties)
                {
                    if (aMailProperties.SendType != "Ne pas envoyer" && Program.Project.ProjectSettings.LanguageField != "[Aucune langue]")
                    {
                        MailMessage MM = new MailMessage();
                        MM.IsBodyHtml = true;
                        SmtpClient SC = new SmtpClient();
                        MM.From = new MailAddress(Program.Project.MailServerSettings.FromEmail, Program.Project.MailServerSettings.FromName);
                        SC.Host = Program.Project.MailServerSettings.Host;
                        SC.Credentials = new NetworkCredential(Program.Project.MailServerSettings.Username, Program.Project.MailServerSettings.Password);

                        foreach (DataRow aRow in Program.Project.Data.Rows)
                        {
                            try
                            {
                                string RowLang = aRow[Program.Project.ProjectSettings.LanguageField].ToString();
                                if ((RowLang == aMailProperties.Name
                                     && aMailProperties.Name != "[Aucune langue]")
                                     || aMailProperties.Name == "[Aucune langue]")
                                {
                                    MM.To.Clear();
                                    MM.To.Add(new MailAddress(aRow[Program.Project.ProjectSettings.EmailField].ToString()));

                                    StringBuilder Body = new StringBuilder();
                                    Body.Append(aMailProperties.Body);
                                    MM.Subject = aMailProperties.Subject;
                                    MM.Body = Body.ToString();

                                    if (MM.To.Count >= 1)
                                    {
                                        try
                                        {
                                            //SC.Send(MM);
                                            SendPerSecondCounter.Increment();
                                            Thread.Sleep(Program.Project.ProjectSettings.SendDelay);
                                        }
                                        catch (Exception ex)
                                        {
                                            throw new ProjectException(Program.Project, "Erreur lors de l'envoi", ex);
                                        }
                                    }
                                }
                            }
                            catch (ProjectException ex)
                            {
                                throw ex;
                            }
                            catch (Exception ex)
                            {
                                throw new ProjectException(Program.Project, "Erreur lors de l'envoi", ex);
                            }
                        }
                    }
                }
            }
            catch (ProjectException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ProjectException(Program.Project, "Erreur lors de l'envoi", ex);
            }
        }
    }
}
