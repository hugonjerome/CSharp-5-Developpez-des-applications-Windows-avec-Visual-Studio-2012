using System;

namespace SelfMailer.Library
{
    public class ProjectSettings : IReportChange
    {
        protected string log;
        protected int sendDelay;
        protected string languageField = string.Empty;
        protected string emailField = string.Empty;
        protected bool hasChanged;

        public string Log
        {
            get { return this.log; }
            set
            {
                if (this.log != value)
                {
                    this.log = value;
                    this.HasChanged = true;
                }
            }
        }
        public int SendDelay
        {
            get { return this.sendDelay; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La valeur doit être supérieure ou égale à 0.", "Délai d'envoi");
                if (this.sendDelay != value)
                {
                    this.sendDelay = value;
                    this.HasChanged = true;
                }
            }
        }
        public string LanguageField
        {
            get { return this.languageField; }
            set
            {
                if (this.languageField != value)
                {
                    this.languageField = value;
                    this.HasChanged = true;
                }
            }
        }
        public string EmailField
        {
            get { return this.emailField; }
            set
            {
                if (this.emailField != value)
                {
                    this.emailField = value;
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

        public event EventHandler<ChangedEventArgs> Changed;
    }
}
