using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_app.Views.Controls
{
    public partial class ChatListItem : UserControl
    {
        public Image Avatar
        {
            get { return pictureBoxAvatar.Image; }
            set
            {
                pictureBoxAvatar.Image = value;
                pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBoxAvatar.Invalidate();
            }
        }

        public string UserName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        public string Message
        {
            get { return labelMessage.Text; }
            set { labelMessage.Text = value; }
        }

        public DateTime Time
        {
            get { return DateTime.Parse(labelTime.Text); }
            set { labelTime.Text = value.ToString("hh:mm tt"); }
        }

        //public int ItemHight { get => this.Height; set => this.Height = value; }
        //public int ItemWidth { get => this.Width; set => this.Width = value; }

        public ChatListItem()
        {
            InitializeComponent();
            pnChatListItem.SizeChanged += PnChatListItem_SizeChanged;
            pnChatListItem.Click += PnChatListItem_Click;
            labelName.Click += PnChatListItem_Click;
            labelMessage.Click += PnChatListItem_Click;
            labelTime.Click += PnChatListItem_Click;
            pictureBoxAvatar.Click += PnChatListItem_Click;
        }

        private void PnChatListItem_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void PnChatListItem_SizeChanged(object sender, EventArgs e)
        {
            int itemHeigh = pnChatListItem.Height;
            int itemWidth = pnChatListItem.Width;
            pictureBoxAvatar.Size = new Size(itemHeigh - 10, itemHeigh - 10);
            pictureBoxAvatar.Location = new Point(5, 5);
            labelName.Location = new Point(itemHeigh + 5, 5);
            labelMessage.Location = new Point(itemHeigh + 5, 30);
            labelTime.Location = new Point(itemWidth - 100, 5);

        }
    }
}
