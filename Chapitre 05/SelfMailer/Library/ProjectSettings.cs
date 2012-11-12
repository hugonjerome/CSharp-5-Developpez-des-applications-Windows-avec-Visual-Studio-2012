using System;

namespace SelfMailer.Library
{
    public class ProjectSettings : IReportChange
    {
        protected bool hasChanged;

        public bool HasChanged
        {
            get { return hasChanged; }
            set
            {
                if (this.hasChanged != value)
                {
                    this.hasChanged = value;
                    if (this.Changed != null)
                        this.Changed(this, new EventArgs());
                }
            }
        }

        public event EventHandler Changed;
    }
}
