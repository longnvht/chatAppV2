using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    public partial class TextMessageItem : UserControl
    {
        private string message;
        private int cornerRadius = 6; // Độ cong góc bo tròn
        private int padding = 10;
        private Color _fillColor = Color.White;
        private int _maxWidth =200;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                CalculateSize();
                Invalidate(); // Trigger a redraw when the message changes
            }
        }

        public Color FillColor 
        { 
            get => _fillColor;
            set
            {
                _fillColor = value;
                Invalidate();
            }
        }

        public int MaxWidth { get => _maxWidth; set => _maxWidth = value; }

        public TextMessageItem()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SizeChanged += MessageControl_SizeChanged;
        }

        private void MessageControl_SizeChanged(object sender, EventArgs e)
        {
            CalculateSize();
            Invalidate();
        }

        private void CalculateSize()
        {
            if (!string.IsNullOrEmpty(message))
            {
                Size textSize = TextRenderer.MeasureText(message, Font);

                if (textSize.Width >= MaxWidth)
                {
                    Width = MaxWidth;
                    Height = TextRenderer.MeasureText(message, Font, new Size(MaxWidth - 2 * padding, 0), TextFormatFlags.WordBreak).Height + 2 * padding;
                }
                else
                {
                    Width = textSize.Width + 2 * padding;
                    Height = textSize.Height + 2 * padding;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            using (GraphicsPath path = CreateRoundedRectangle(ClientRectangle, cornerRadius))
            using (Brush backgroundBrush = new SolidBrush(FillColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(backgroundBrush, path);
            }

            if (!string.IsNullOrEmpty(message))
            {
                Rectangle textRect = new Rectangle(padding, padding, Width - 2 * padding, Height - 2 * padding);
                TextRenderer.DrawText(e.Graphics, message, Font, textRect, ForeColor, FillColor, TextFormatFlags.WordBreak);
            }
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            roundedRect.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            roundedRect.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            roundedRect.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            roundedRect.CloseFigure();
            return roundedRect;
        }
    }
}
