using System;

namespace SelfMailer.Library
{
    interface IReportChange
    {
        bool HasChanged
        {
            get;
            set;
        }
        event EventHandler Changed;
    }
}
