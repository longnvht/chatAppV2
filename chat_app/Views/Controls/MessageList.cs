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
    public partial class MessageList : UserControl
    {

        private TextMessageItem _lastMessageItem;
        public MessageList()
        {
            InitializeComponent();
            AutoScroll = true; // Enable auto-scrolling
            this.SizeChanged += MessageList_SizeChanged;
        }

        private void MessageList_SizeChanged(object sender, EventArgs e)
        {
            RefreshMessages();
        }

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


        private void AddNewMessage(MessageItemModel message)
        {
            TextMessageItem item = new TextMessageItem();
            item.MaxWidth = Width - 2 * xOffset - 20;
            item.Font = Font;
            item.ForeColor = ForeColor;
            item.BackColor = BackColor;
            item.Text = message.MessageContent;

            if (_lastMessageItem != null) { item.Top = _lastMessageItem.Bottom + 5; }
            else { item.Top = 5; }

            if (message.SenderID == SenderID) // Tin nhắn đi
            {
                item.Left = Width - item.Width - xOffset;
                item.FillColor = Color.FromArgb(232, 235, 250);
            }
            else // Tin nhắn đi
            {
                item.Left = xOffset;
                item.FillColor = Color.FromArgb(255, 255, 255);
            }

            Controls.Add(item);
            _lastMessageItem = item;
        }

        private void AddOldMessage(MessageItemModel message)
        {
            TextMessageItem item = new TextMessageItem();
            item.MaxWidth = Width - 2 * xOffset - 20;
            item.Font = Font;
            item.ForeColor = ForeColor;
            item.BackColor = BackColor;
            item.Text = message.MessageContent;
            item.Top = 5;

            foreach (TextMessageItem crItem in Controls)
            {
                crItem.Top += item.Height + 5;
            }

            if (message.SenderID == SenderID) // Tin nhắn đi
            {
                item.Left = Width - item.Width - xOffset;
                item.FillColor = Color.FromArgb(232, 235, 250);
            }
            else // Tin nhắn đi
            {
                item.Left = xOffset;
                item.FillColor = Color.FromArgb(255, 255, 255);
            }

            Controls.Add(item);
        }
        

        private void RefreshMessages()
        {
            Controls.Clear(); // Clear existing message controls
            _lastMessageItem = null;

            if (messageSource != null && messageSource.DataSource is IEnumerable<MessageItemModel> messageItems)
            {

                foreach (MessageItemModel message in messageItems)
                {
                    AddNewMessage(message);
                }

                _lastMessageItem.Focus();
            }
        }
    }
}
