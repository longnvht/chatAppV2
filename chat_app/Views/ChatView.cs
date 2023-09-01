using chat_app.Models;
using chat_app.Models.Interfaces;
using chat_app.Presenters;
using chat_app.Repositorys;
using chat_app.Views.Interfaces;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Unity;
using ChatList = chat_app.Models.ChatListModel;

namespace chat_app
{
    public partial class ChatView : Form, IChatView
    {
        private int _minHeightTextBox = 40;
        private int _maxHeightTextBox = 200;
        private ChatListModel  _currentChatList;

        public ChatView()
        {
            InitializeComponent();
            AssignEvent();
        }

        private void AssignEvent()
        {
            this.Load += ChatView_Load;
            chatListControl.ItemClicked += (s, e) => 
            {
                CurrentChatList = s as ChatListModel;
            };
            _txtMessage.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && e.Shift)
                {
                    return;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (!String.IsNullOrEmpty(_txtMessage.Text))
                    {
                        AddMessage?.Invoke(this, EventArgs.Empty);
                    }
                }
            };
            btnSend.Click += (s, e) =>
            {
                if (!String.IsNullOrEmpty(_txtMessage.Text))
                {
                    AddMessage?.Invoke(this, EventArgs.Empty);
                }
            };

            _txtMessage.TextChanged += ResizeMesageTextBox;
        }

        private void ResizeMesageTextBox(object sender, EventArgs e)
        {
            var text = _txtMessage.Text;
            int maxWidth = _txtMessage.Width - _txtMessage.Margin.Left - _txtMessage.Margin.Right;
            var textSize = TextRenderer.MeasureText(text, _txtMessage.Font, new Size(maxWidth, 0), TextFormatFlags.WordBreak);
            int newHeight = textSize.Height + _txtMessage.Margin.Top + _txtMessage.Margin.Bottom + 10;
            if (newHeight <= _minHeightTextBox)
            {
                pnMoreAction.Height = _minHeightTextBox + 40;
                _txtMessage.Height = _minHeightTextBox;
                _txtMessage.ScrollBars = ScrollBars.None;
            }
            else if (newHeight > _minHeightTextBox & newHeight <= _maxHeightTextBox)
            {
                pnMoreAction.Height = newHeight + 40;
                _txtMessage.Height = newHeight;
                _txtMessage.ScrollBars = ScrollBars.None;
            }
            else
            {
                _txtMessage.AutoScroll = true;
                _txtMessage.ScrollBars = ScrollBars.Vertical;
            }



        }

        private void ChatView_Load(object sender, EventArgs e)
        {
            ChatRepository repository = ConfigUnity.unityContainer.Resolve<ChatRepository>();
            Presenter = new ChatPresenter(this, repository);
            messageListControl.SenderID = 9;
            CurrentChatList = null;
        }

        public ChatListModel CurrentChatList 
        { 
            get => _currentChatList;
            set
            {
                _currentChatList = value;
                if (_currentChatList != null)
                {
                    lblChatName.Text = _currentChatList.PartnerName;
                    ChatItemSelected?.Invoke(this, EventArgs.Empty);
                    _txtMessage.Enabled = true;
                    MessageText = "";
                }
                else _txtMessage.Enabled = false;
            }
        }
        public string CurrentMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Users> MemberGroup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ChatPresenter Presenter { private get; set; }
        public string MessageText { get => _txtMessage.Text; set => _txtMessage.Text = value; }

        public event EventHandler ChatItemSelected;
        public event EventHandler AddMessage;
        public event EventHandler AddChatGroup;
        public event EventHandler AddMemberToGroup;
        public event EventHandler RemoveMemberFromGroup;



        public void SetChatListBindingSource(BindingSource chatListBidingSource)
        {
            chatListControl.DataSource = chatListBidingSource;
        }

        public void SetListMembersBindingSource(BindingSource listMembersBidingSource)
        {
        }

        public void SetMessageListBindingSource(BindingSource mesageSource)
        {
            messageListControl.MessageSource = mesageSource;
        }

    }
}
