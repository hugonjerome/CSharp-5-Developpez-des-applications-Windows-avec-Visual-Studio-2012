using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace SelfMailer.Library
{
    public static class MailerTools
    {
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
                                            System.Threading.Thread.Sleep(Program.Project.ProjectSettings.SendDelay);
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
