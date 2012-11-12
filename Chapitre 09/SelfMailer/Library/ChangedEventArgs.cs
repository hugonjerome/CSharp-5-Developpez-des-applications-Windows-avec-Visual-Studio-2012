using System;

namespace SelfMailer.Library
{
    public class ChangedEventArgs : EventArgs
    {
        public bool HasChanged { get; protected set; }
        public ChangedEventArgs(bool hasChanged)
        {
            this.HasChanged = hasChanged;
        }
    }
}
