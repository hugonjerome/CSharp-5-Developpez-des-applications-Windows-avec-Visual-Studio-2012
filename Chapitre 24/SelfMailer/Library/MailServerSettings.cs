using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SelfMailer.Library
{
    public class MailServerSettings : IReportChange
    {
        protected string fromName;
        protected string fromEmail;
        protected string host;
        protected string username;
        protected string password;
        protected bool hasChanged;

        public string FromName
        {
            get { return this.fromName; }
            set
            {
                if (this.fromName != value)
                {
                    this.fromName = value;
                    this.HasChanged = true;
                }
            }
        }
        public string FromEmail
        {
            get { return this.fromEmail; }
            set
            {
                string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                                 @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
                                 @"(([a-zA-Z0-9\-]+\.)+))" +
                                 @"([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex reg = new Regex(pattern);
                if (reg.IsMatch(value))
                {
                    if (this.fromEmail != value)
                    {
                        this.fromEmail = value;
                        this.HasChanged = true;
                    }
                }
            }
        }
        public string Host
        {
            get { return this.host; }
            set
            {
                if (this.host != value)
                {
                    this.host = value;
                    this.HasChanged = true;
                }
            }
        }
        public string Username
        {
            get { return this.username; }
            set
            {
                if (this.username != value)
                {
                    this.username = value;
                    this.HasChanged = true;
                }
            }
        }
        public string Password
        {
            get { return this.password; }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    this.HasChanged = true;
                }
            }
        }
        [XmlIgnore]
        public bool HasChanged
        {
            get { return hasChanged; }
            set
            {
                if (this.hasChanged != value)
                {
                    this.hasChanged = value;
                    if (this.Changed != null)
                        this.Changed(this, new ChangedEventArgs(this.HasChanged));
                }
            }
        }

        public event EventHandler<ChangedEventArgs> Changed;
    }
}
