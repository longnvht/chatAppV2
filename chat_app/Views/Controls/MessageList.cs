using chat_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    public partial class MessageList : Panel
    {
        public int SenderID { get; set; }
        private BindingSource messageSource;
        private int xOffset =80;
        private int _lastWidth;

        public BindingSource MessageSource
        {
            get { return messageSource; }
            set
            {
                messageSource = value;
                if (messageSource != null) { messageSource.ListChanged += MessageSource_ListChanged; }
            }
        }

        private void MessageSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshMessages();
        }

        public MessageList()
        {
            InitializeComponent();
            SizeChanged += MessageList_SizeChanged;
            AutoScroll = true; // Enable auto-scrolling
        }

        private void MessageList_SizeChanged(object sender, EventArgs e)
        {
            if(_lastWidth != Width)
            {
                _lastWidth = Width;
                RefreshMessages();
            }
            
        }

        private void RefreshMessages()
        {
            Controls.Clear(); // Clear existing message controls

            if (messageSource != null && messageSource.DataSource is IEnumerable<MessageItemModel> messageItems)
            {
                int yOffset = 5;

                foreach (MessageItemModel message in messageItems)
                {
                    TextMessageItem item = new TextMessageItem();
                    item.MaxWidth = Width - 2*xOffset - 20;
                    item.Font = Font;
                    item.ForeColor = ForeColor;
                    item.BackColor = BackColor;
                    item.Message = message.MessageContent;

                    if (message.SenderID == SenderID) // Tin nhắn đi
                    {
                        item.Location = new Point(Width - item.Width - xOffset, yOffset);
                        item.FillColor = Color.FromArgb(232, 235, 250);
                    }
                    else // Tin nhắn đi
                    {
                        item.Location = new Point(xOffset, yOffset);
                        item.FillColor = Color.FromArgb(255, 255, 255);
                    }

                    Controls.Add(item);

                    yOffset += item.Height +5;
                }

                if (Controls.Count > 0)
                {
                    var lastMessage = Controls[Controls.Count - 1];
                    ScrollControlIntoView(lastMessage);
                    lastMessage.Focus();
                }
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            RefreshMessages();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            RefreshMessages();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            RefreshMessages();
        }

    }
}
