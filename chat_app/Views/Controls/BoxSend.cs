using chat_app.Resources;
using System;
using System.Windows.Forms;

namespace chat_app.Controls
{
    public partial class BoxSend : UserControl
    {
        public BoxSend()
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
            BoxSend boxSend = new BoxSend();
            lblMessage.Height = UiList.GetTextHeight(lblMessage) + 10;
            boxSend.Height = lblMessage.Top + boxSend.Top + lblMessage.Height;
            this.Height = boxSend.Bottom + 10;
        }

        private void BoxSend_Load(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void BoxSend_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
