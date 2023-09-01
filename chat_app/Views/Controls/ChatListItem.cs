using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    public partial class ChatListItem : UserControl
    {
        private string _lastMessage;
        private DateTime  _lastChatTime;
        private float _textTimeWidth;
        private Image _image;
        private Color _fillColor = Color.FromArgb(240,240,240);
        private int _cornerRadius = 6;
        private Color _activeColor;
        private Color _hoverColor = Color.White;
        private System.Drawing.Size _imageSize = new System.Drawing.Size(40, 40);
        private bool _checked = false;

        public string LastMessage
        {
            get { return _lastMessage; }
            set { _lastMessage = value; }
        }

        public DateTime LastChatTime
        {
            get { return _lastChatTime; }
            set { _lastChatTime = value; }
        }

        public Image Image { get => _image; set => _image = value; }
        public Color FillColor { get => _fillColor; set => _fillColor = value; }
        public int CornerRadius { get => _cornerRadius; set => _cornerRadius = value; }
        public Color HoverColor { get => _hoverColor; set => _hoverColor = value; }
        public System.Drawing.Size ImageSize { get => _imageSize; set => _imageSize = value; }
        public bool Checked 
        { 
            get => _checked;
            set
            {
                _checked = value;
                if (_checked) _activeColor = HoverColor;
                else _activeColor = FillColor;

                Invalidate();
            }

        }

        public ChatListItem()
        {
            InitializeComponent();
            _activeColor = FillColor;
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            // Clear the control
            //e.Graphics.Clear(Color.White);
            using (GraphicsPath path = CreateRoundedRectangle(ClientRectangle, CornerRadius))
            using (Brush backgroundBrush = new SolidBrush(_activeColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(backgroundBrush, path);
            }
            // Draw avatar
            if (Image != null)
            {
                System.Drawing.Point point = new System.Drawing.Point(5, (Height - ImageSize.Height)/2);
                e.Graphics.DrawImage(Image, new Rectangle(point, ImageSize));
            }

            using (Font timeFont = new Font("Arial", 8))
            {
                var textTime = LastChatTime.ToString("hh:mm tt");
                SizeF timeSize = e.Graphics.MeasureString(textTime, timeFont);
                _textTimeWidth = timeSize.Width;
                PointF timePosition = new PointF(Width - timeSize.Width - 10, 5);
                e.Graphics.DrawString(textTime, timeFont, Brushes.Gray, timePosition);
            }

            // Draw name
            using (Font nameFont = new Font("Arial", 10, System.Drawing.FontStyle.Bold))
            {
                int maxTextWidth = Width - 50 - (Int32)_textTimeWidth;
                var trimText = LimitTextWidth(Text, maxTextWidth, nameFont);
                e.Graphics.DrawString(trimText, nameFont, Brushes.Black, new PointF(50, 10));
            }

            // Draw message
            using (Font messageFont = new Font("Arial", 9))
            {
                int maxMessageWidth = Width - 60;
                var trimMessage = LimitTextWidth(LastMessage, maxMessageWidth, messageFont);
                e.Graphics.DrawString(trimMessage, messageFont, Brushes.Black, new PointF(50, 30));
            }

            // Draw time
            
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            _activeColor = HoverColor;
            Invalidate();

            // Thực hiện hành động khi sự kiện MouseHover xảy ra
            // Ví dụ: thay đổi màu nền, hiển thị tooltip, vv.
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if(!Checked)
            {
                _activeColor = FillColor;
                Invalidate();
            }
        }

        private string LimitTextWidth(string text, int maxWidth, Font font)
        {
            System.Drawing.Size textSize = TextRenderer.MeasureText(text, font);

            if (textSize.Width <= maxWidth)
            {
                return text;
            }
            else
            {
                int ellipsisWidth = TextRenderer.MeasureText("...", font).Width;
                int maxVisibleWidth = maxWidth - ellipsisWidth;
                string truncatedText = text;

                while (TextRenderer.MeasureText(truncatedText, font).Width > maxVisibleWidth && truncatedText.Length > 0)
                {
                    truncatedText = truncatedText.Substring(0, truncatedText.Length - 1);
                }

                return truncatedText + "...";
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
