using System;

namespace SelfMailer.Library
{
    internal interface IReportChildrenChange : IReportChange
    {
        void ChildChanged(object sender, EventArgs e);
    }
}
