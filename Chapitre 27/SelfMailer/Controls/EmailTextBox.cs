using System.Drawing;
using System.Text.RegularExpressions;

namespace SelfMailer.Controls
{
    public class EmailTextBox : System.Windows.Forms.TextBox
    {
        protected Color PreviousBackColor { get; set; }

        public EmailTextBox()
        {
            this.PreviousBackColor = this.BackColor;
        }

        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\." +
                            @"[0-9]{1,3}\.[0-9]{1,3}\.)|" +
                            @"(([a-zA-Z0-9\-]+\.)+))" +
                            @"([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(this.Text))
            {
                this.BackColor = Color.Bisque;
                e.Cancel = true;
            }
            else
                this.BackColor = this.PreviousBackColor;
        }
    }
}
