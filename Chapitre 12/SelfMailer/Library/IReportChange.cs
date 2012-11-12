using System;

namespace SelfMailer.Library
{
    public interface IReportChange
    {
        bool HasChanged
        {
            get;
            set;
        }
        event EventHandler<ChangedEventArgs> Changed;
    }
}
