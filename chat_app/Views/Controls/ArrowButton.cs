using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    public class ArrowButton: Guna2Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int arrowThickness = 1;
            Color arrowColor = this.ForeColor;

            var graph = e.Graphics;
            var arrowSize = new Size(10, 5);
            Rectangle rect = new Rectangle(this.Width - arrowSize.Width * 2, this.Height / 2 - arrowSize.Height / 2, arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                //Drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Left + rect.Width/2, rect.Bottom);
                path.AddLine(rect.Left + rect.Width / 2, rect.Bottom, rect.Right, rect.Top);
                graph.DrawPath(pen, path);
            }
        }
    }
}
