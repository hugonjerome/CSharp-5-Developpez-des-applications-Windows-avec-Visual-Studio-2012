using System.Drawing;

namespace SelfMailer.Controls
{
    public class CustomControl : System.Windows.Forms.Control
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            string s = "Bonjour !";
            Font font = new Font("Arial", 50, FontStyle.Italic);
            while ((e.Graphics.MeasureString(s, font).Height > e.ClipRectangle.Height
                || e.Graphics.MeasureString(s, font).Width > e.ClipRectangle.Width
               ) && font.Size >= 1)
            {
                font = new Font("Arial", font.Size - 1, FontStyle.Italic);
            }
            e.Graphics.DrawString(s, font, Brushes.Black, 0, 0);
        }
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            this.Refresh();
        }
    }
}
