using chat_app.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chat_app.Controls
{
    public partial class BoxReceive : UserControl
    {
        public BoxReceive()
        {
            InitializeComponent();
        }
        public string Message
        {
            get => lblMessage.Text;
            set
            {
                lblMessage.Text = value;
                AdjustHeight();
            }
        }

        private void AdjustHeight()
        {
            BoxReceive boxSend = new BoxReceive();
            imgAvatar.Location = new Point(4, 3);
            lblMessage.Height = UiList.GetTextHeight(lblMessage) + 10;
            boxSend.Height = lblMessage.Top + boxSend.Top + lblMessage.Height;
            this.Height = boxSend.Bottom + 10;
        }

        public Image Avatar { get => imgAvatar.Image; set => imgAvatar.Image = value; }

        private void BoxReceive_Load(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void BoxReceive_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
