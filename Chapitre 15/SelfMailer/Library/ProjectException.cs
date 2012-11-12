using System;

namespace SelfMailer.Library
{
    public class ProjectException : ApplicationException
    {
        public Project Project { get; protected set; }

        public ProjectException(Project project)
            : base()
        {
            this.Project = project;
        }
        public ProjectException(Project project, string message)
            : base(message)
        {
            this.Project = project;
        }
        public ProjectException(Project project, string message, Exception innerException)
            : base(message, innerException)
        {
            this.Project = project;
        }
    }
}
