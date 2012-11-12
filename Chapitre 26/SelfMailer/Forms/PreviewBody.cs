using System.Windows.Forms;

namespace SelfMailer.Forms
{
    public partial class PreviewBody : Form
    {
        public PreviewBody() : this(null) { }
        public PreviewBody(string MailBody)
        {
            InitializeComponent();
            this.wbBody.DocumentText = MailBody;
        }
    }
}
