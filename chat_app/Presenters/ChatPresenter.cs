using chat_app.Models;
using chat_app.Models.Interfaces;
using chat_app.Repositorys;
using chat_app.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace chat_app.Presenters
{
    public class ChatPresenter
    {
        #region Properties - Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ChatPresenter).Name);

        private IChatView _view;
        private IChatRepository _repository;
        private BindingSource _chatListSource;
        private BindingSource _memberListSource;
        private BindingSource _messageListSource;
        private IEnumerable<ChatListModel> _chatList;
        private IEnumerable<MessageItemModel> _messageList;
        private IEnumerable<MessageItemModel> _memberList;

        MqttClient mqttClient;

        #endregion

        public ChatPresenter(IChatView chatView, IChatRepository chatRepository)
        {
            _chatListSource = new BindingSource();
            _memberListSource = new BindingSource();
            _messageListSource = new BindingSource();

            _view = chatView;
            _repository = chatRepository;
            _view.Presenter = this;


            _view.SetChatListBindingSource(_chatListSource);
            _view.SetListMembersBindingSource(_memberListSource);
            _view.SetMessageListBindingSource(_messageListSource);
            _view.ChatItemSelected += LoadMessageList;
            _view.AddMessage += AddNewMessage;

            LoadData();

        }

        private async void AddNewMessage(object sender, EventArgs e)
        {
            await _repository.AddHistoryChat(9, _view.CurrentChatList.PartnerID, _view.MessageText);
            _view.MessageText = "";
            ReloadMessage();
        }

        private async void ReloadMessage()
        {
            _messageList = await _repository.GetMessageLists(9, _view.CurrentChatList.PartnerID);
            _messageListSource.DataSource = _messageList;
        }

        private void LoadMessageList(object sender, EventArgs e)
        {
            ReloadMessage();
        }

        private async void LoadData()
        {
            _chatList = await _repository.GetListChats(9);
            _chatListSource.DataSource = _chatList;
        }
    }
}