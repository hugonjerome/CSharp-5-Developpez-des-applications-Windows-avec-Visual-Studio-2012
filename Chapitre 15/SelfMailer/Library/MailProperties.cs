using System;

namespace SelfMailer.Library
{
    public class MailProperties : IReportChange, IKey
    {
        protected string name;
        protected string sendType;
        protected string subject;
        protected string body;
        protected bool hasChanged;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.HasChanged = true;
                }
            }
        }
        public string SendType
        {
            get { return this.sendType; }
            set
            {
                if (this.sendType != value)
                {
                    this.sendType = value;
                    this.HasChanged = true;
                }
            }
        }
        public string Subject
        {
            get { return this.subject; }
            set
            {
                if (this.subject != value)
                {
                    this.subject = value;
                    this.HasChanged = true;
                }
            }
        }
        public string Body
        {
            get { return this.body; }
            set
            {
                if (this.body != value)
                {
                    this.body = value;
                    this.HasChanged = true;
                }
            }
        }
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
        public string Key
        {
            get { return this.name; }
        }

        public event EventHandler<ChangedEventArgs> Changed;
    }
}
