using System;

namespace SelfMailer.Library
{
    interface IReportChildrenChange : IReportChange
    {
        void ChildChanged(object sender, EventArgs e);
    }
}
