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

        private readonly IChatView _chatView;
        private IChatRepository _chatRepository;
        private int curTop = 10;
        private readonly BindingList<Users> memberSelection = new BindingList<Users>();
        private BindingList<Users> lstMembers = new BindingList<Users>();
        private readonly BindingSource chatListBidingSource;
        private readonly BindingSource listMembersBidingSource;
        private IEnumerable<ChatList> chatList;
        MqttClient mqttClient;

        public ChatPresenter(IChatView chatView, IChatRepository chatRepository)
        {
            _chatView = chatView;
            _chatRepository = chatRepository;
            this.chatListBidingSource = new BindingSource();
            this.listMembersBidingSource = new BindingSource();

            _chatView.ChatView_Load += _chatView_ChatView_Load;
            _chatView.btnSend_Click += _chatView_btnSend_Click;
            _chatView.ChatView_Resize += _chatView_ChatView_Resize;
            _chatView.txtMessage_TextChanged += _chatView_txtMessage_TextChanged;
            _chatView.itemChatList_Click += _chatView_itemChatList_Click;
            _chatView.btnAddMember_Click += _chatView_btnAddMember_Click;
            _chatView.btnDeleteMember_Click += _chatView_btnDeleteMember_Click;
            _chatView.btnSelect_Click += _chatView_btnSelect_Click;
            _chatView.btnCancel_Click += _chatView_btnCancel_Click;
            _chatView.txtSearchMember_TextChanged += _chatView_txtSearchMember_TextChanged;
            _chatView.txtNewChat_Click += _chatView_txtNewChat_Click;

            _chatView.SetDataSourceChatList(chatListBidingSource);
            _chatView.SetDataSourceListMembers(listMembersBidingSource);

            _chatView.Show();
        }
        #endregion

        #region Events

        private void _chatView_ChatView_Load(object sender, EventArgs e)
        {
            //Lấy UserLoginID and NameStaff
            if (Program.sessionLogin["Id"] != null)
            {
                _chatView.UserLoginID = Convert.ToInt32(Program.sessionLogin["Id"]);
            }
            else
            {
                _log.Error("Program.sessionLogin[\"Id\"] is null.");
            }
            if (Program.sessionLogin["Name"] != null)
            {
                _chatView.strNameStaff = (Program.sessionLogin["Name"]).ToString();
            }
            else
            {
                _log.Error("Program.sessionLogin[\"Name\"] is null.");
            }
            GetDataChatList();

            /* Code cũ
            _chatView.lstUsers = await _chatRepository.GetListUsers(strUserFrom: _chatView.strUserLogin);

            // 1. Create list button.
            if (_chatView.lstButton == null)
            {
                _chatView.lstButton = new List<Guna2GradientButton>();
            }

            if (_chatView.lstUsers != null)
            {
                // 1.Add to List Button
                int countUsers = _chatView.lstUsers.Count;
                for (int i = 0; i < countUsers; i++)
                {
                    _chatView.lstButton.Add(_chatView.CreateButton(i));
                }

                // 2. Add to flowlayoutpanel.
                _chatView.flpUsers.Controls.AddRange(_chatView.lstButton.ToArray());
                _chatView.lstButton = null;
                _log.Info("Create button list and add button to flowlayoutpanel.");
            }
            else
            {
                _log.Error("_chatView.lstUsers is null.");
            }*/

            Thread t = new Thread(() =>
            {
                Task.Run(() =>
                {
                    mqttClient = new MqttClient("192.168.0.55");
                    mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                    mqttClient.Subscribe(new string[] { "Listen/" + _chatView.strUserLogin }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                    mqttClient.Connect("APP1", "vinammqtt", "Vinam@12345", false, 0, true, "LWT/" + _chatView.strUserLogin, "OffLine", true, 60);
                    mqttClient.Publish("LWT/" + _chatView.strUserLogin, Encoding.UTF8.GetBytes("OnLine"), 0, false);
                });
            });
            t.Start();
        }

        private async void _chatView_itemChatList_Click(object sender, EventArgs e)
        {
            ChatList chatList = sender as ChatList;
            if (chatList != null)
            {
                _chatView.ReceiverID = chatList.Id;
                _chatView.TypeChat = chatList.TypeChat;
                if (_chatView.TypeChat == 0)
                {
                    _chatView.listMembers = await _chatRepository.GetChatMembers(senderID: _chatView.UserLoginID, receiverID: _chatView.ReceiverID);
                }
                else
                {
                    _chatView.listMembers = await _chatRepository.GetGroupMembers(groupID: _chatView.ReceiverID);
                }
                _chatView.lsbMembers.DataSource = _chatView.listMembers;
                _chatView.lsbMembers.ValueMember = "Id";
                _chatView.lsbMembers.DisplayMember = "strNameStaff";
                _chatView.statusForm = '1';
                _chatView.SetStatusForm();
                _chatView.txtNameChat.Text = chatList.StrNameStaff;
                AddDataToPanel();
            }
        }

        private void _chatView_txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_chatView.txtMessage.Text) || string.IsNullOrWhiteSpace(_chatView.txtMessage.Text))
            {
                // Để đây xíu bắt hiển thị nút gửi
            }
        }

        private async void _chatView_btnSend_Click(object sender, EventArgs e)
        {
            bool bResult = await _chatRepository.AddHistoryChat(senderID: _chatView.UserLoginID, receiverID: _chatView.ReceiverID, strContent: _chatView.txtMessage.Text);

            if (bResult)
            {
                Thread t = new Thread(() =>
                {
                    Task.Run(() =>
                    {
                        if (mqttClient != null && mqttClient.IsConnected)
                        {
                            mqttClient.Publish("Send/" + _chatView.ReceiverID, Encoding.UTF8.GetBytes(_chatView.txtMessage.Text));
                            //_chatView.lstbChat.Invoke((MethodInvoker)(() => _chatView.lstbChat.Items.Add(_chatView.strNameStaffLogin + ": " + _chatView.txtMessage.Text)));
                        }
                    });
                });
                t.Start();
                AddDataToPanel();
                GetDataChatList();
            }
            else
            {
                _log.Error("Thêm lịch sử chat thất bại!");
            }
            _chatView.txtMessage.Text = string.Empty;
        }

        private void _chatView_ChatView_Resize(object sender, EventArgs e)
        {
            AddDataToPanel();
        }

        private void _chatView_btnAddMember_Click(object sender, EventArgs e)
        {
            _chatView.statusForm = '2';
            _chatView.SetStatusForm();
            lstMembers = _chatRepository.GetListMembers(userLoginID: _chatView.UserLoginID).Result as BindingList<Users>;
            listMembersBidingSource.DataSource = lstMembers;
        }

        private async void _chatView_btnDeleteMember_Click(object sender, EventArgs e)
        {
            ChatList memberDelete = (ChatList)_chatView.lsbMembers.SelectedItem;
            if (memberDelete.Id == _chatView.UserLoginID)
            {
                MessageBox.Show("Bạn không thể tự xóa bản thân mình!");
            }
            else
            {
                bool resultDelete = await _chatRepository.DeleteMember(groupID: _chatView.ReceiverID, memberID: memberDelete.Id);
                if (resultDelete)
                {
                    _chatView.listMembers.Remove(memberDelete);
                }
                else
                {
                    _log.Error("Xóa thành viên thất bại!");
                }
            }
        }

        private void _chatView_txtNewChat_Click(object sender, EventArgs e)
        {
            _chatView.statusForm = '2';
            _chatView.SetStatusForm();
            lstMembers = _chatRepository.GetListNewChat(userLoginID: _chatView.UserLoginID).Result as BindingList<Users>;
            listMembersBidingSource.DataSource = lstMembers;
        }

        private void _chatView_btnCancel_Click(object sender, EventArgs e)
        {
            _chatView.statusForm = '3';
            _chatView.SetStatusForm();
        }

        private async void _chatView_btnSelect_Click(object sender, EventArgs e)
        {
            if (_chatView.typeBtnSelect == 0)
            {
                bool bResult = await _chatRepository.AddHistoryChat(senderID: _chatView.UserLoginID, receiverID: _chatView.memberID, strContent: _chatView.strNameStaff + " đã tạo cuộc trò chuyện!");
                if (bResult)
                {
                    GetDataChatList();
                    var firstItem = chatList.First();
                    _chatView.ReceiverID = firstItem.Id;
                    AddDataToPanel();
                }
            }
            else
            {
                if (_chatView.listMembers.Count == 3 || _chatView.listMembers.Count == 2)
                {
                    /* 
                     * DONE thêm người mới vào danh sách listMembers
                     * DONE tạo tên group với các tên nối với nhau
                     * DONE tạo group với danh sách listMembers
                     * DONE gửi 1 tin nhắn tới group từ người tạo
                     * DONE load lại data chatlist
                     */
                    bool resultCreate = await _chatRepository.AddGroup(strNameGroup: _chatView.txtNameChat.Text);
                    bool resultAddMember = false;
                    bool bResult = false;
                    if (resultCreate)
                    {
                        foreach (ChatList item in _chatView.listMembers)
                        {
                            resultAddMember = await _chatRepository.AddMemberNewGroup(memberGroupID: item.Id);
                        }
                    }
                    else
                    {
                        _log.Error("Tạo group thất bại!");
                    }
                    if (resultCreate && resultAddMember)
                    {
                        bResult = await _chatRepository.AddMessageNewGroup(senderID: _chatView.UserLoginID, strContent: _chatView.strNameStaff + " đã tạo nhóm chat!");
                    }
                    else
                    {
                        _log.Error("Lưu nhóm thất bại!");
                    }
                    if (bResult)
                    {
                        GetDataChatList();
                        var firstItem = chatList.First();
                        _chatView.ReceiverID = firstItem.Id;
                        AddDataToPanel();
                    }
                }
                else if (_chatView.listMembers.Count > 3)
                {
                    bool bResult = await _chatRepository.AddMemberGroup(groupID: _chatView.ReceiverID, memberGroupID: _chatView.memberID);
                    if (bResult)
                    {
                        GetDataChatList();
                    }
                    else
                    {
                        _log.Error("Thêm thành viên thất bại!");
                    }
                }
            }
        }

        private void _chatView_txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            var matchingItems = lstMembers.Where(item => item.strNameStaff.ToLower().Contains(_chatView.txtSearchMember.Text.ToLower())).ToList();
            listMembersBidingSource.DataSource = matchingItems;
        }

        /* Code cũ
        //private void _chatView_btnCreateGroup_Click(object sender, EventArgs e)
        //{
        //    _chatView.grbCreateGroup.Visible = true;
        //    _chatView.grbCreateGroup.Dock = DockStyle.Right;
        //    if (_chatRepository == null)
        //    {
        //        _chatRepository = new ChatRepository();
        //    }
        //    _chatView.lstMembers = _chatRepository.GetListMembers(userLoginID: _chatView.UserLoginID).Result as BindingList<Users>;

        //    _chatView.lsbAllUsers.ValueMember = "strUserLogin";
        //    _chatView.lsbAllUsers.DisplayMember = "strNameStaff";
        //    _chatView.lsbAllUsers.DataSource = _chatView.lstMembers;
        //}

        //private async void _chatView_btnDeleteGroup_Click(object sender, EventArgs e)
        //{
        //    if (_chatView.ReceiverID > 0)
        //    {
        //        if (_chatRepository == null)
        //        {
        //            _chatRepository = new ChatRepository();
        //        }
        //        bool bResult = await _chatRepository.DeleteGroup(groupID: _chatView.ReceiverID);
        //        if (bResult)
        //        {
        //            GetDataChatList();
        //        }
        //        else
        //        {
        //            _log.Error("Xóa group thất bại!");
        //        }
        //    }
        //}

        //private void _chatView_btnCancel_Click(object sender, EventArgs e)
        //{
        //    _chatView.grbCreateGroup.Visible = false;
        //}

        //private async void _chatView_btnSave_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(_chatView.txtNameGroup.Text) || string.IsNullOrWhiteSpace(_chatView.txtNameGroup.Text))
        //    {
        //        MessageBox.Show("Bạn chưa đặt tên nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    else if (_chatView.lsbMember.Items.Count == 0)
        //    {
        //        MessageBox.Show("Bạn chưa thêm thành viên vào nhóm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    bool resultAddMember = false;
        //    // Khai báo danh sách mới để chứa các ValueMember của các mục trong ListBox
        //    List<int> valueMembersList = new List<int>();

        //    // Thêm ID người tạo vào danh sách
        //    valueMembersList.Add(_chatView.UserLoginID);

        //    // Duyệt qua tất cả các mục trong ListBox lsbMember
        //    foreach (var item in _chatView.lsbMember.Items)
        //    {
        //        if (item is Users user) // Ép kiểu đối tượng sang Users
        //        {
        //            // Lấy ValueMember từ mục và thêm vào danh sách mới
        //            valueMembersList.Add(user.iID);
        //        }
        //    }

        //    bool resultCreate = await _chatRepository.AddGroup(strNameGroup: _chatView.txtNameGroup.Text);

        //    if (resultCreate)
        //    {
        //        foreach (var item in valueMembersList)
        //        {
        //            resultAddMember = await _chatRepository.AddMemberGroup(memberGroupID: item);
        //        }
        //    }
        //    if (resultCreate && resultAddMember)
        //    {
        //        _chatView.grbCreateGroup.Visible = false;
        //        _chatView.txtNameGroup.Text = string.Empty;
        //        _chatView.txtSearchMember.Text = string.Empty;
        //        this.memberSelection.Clear();
        //        GetDataChatList();
        //    }
        //    else
        //    {
        //        _log.Error("Lưu nhóm thất bại!");
        //    }
        //}

        //private void _chatView_txtSearchMember_TextChanged(object sender, EventArgs e)
        //{
        //    SearchListBoxAllUsers(_chatView.txtSearchMember.Text.ToString());
        //}

        //private void _chatView_btnDeleteMember_Click(object sender, EventArgs e)
        //{
        //    if (_chatView.lsbMember.SelectedIndex != -1)
        //    {
        //        Users selectedItem = (Users)_chatView.lsbMember.SelectedItem;

        //        // Xóa mục đã chọn khỏi danh sách BidingList mới
        //        memberSelection.Remove(selectedItem);

        //        // Thêm mục đã chọn vào danh sách BidingList cũ
        //        _chatView.lstMembers.Add(selectedItem);

        //        // Sắp xếp lại BidingList lstMembers khi thêm đối tượng mới
        //        _chatView.lstMembers = new BindingList<Users>(_chatView.lstMembers.OrderBy(user => user.strNameStaff).ToList());

        //        // Gán DataSouce cho lsbAllUsers
        //        _chatView.lsbAllUsers.DataSource = _chatView.lstMembers;
        //    }
        //}

        //private void _chatView_btnAddMember_Click(object sender, EventArgs e)
        //{
        //    if (_chatView.lsbAllUsers.SelectedIndex != -1)
        //    {
        //        Users selectedItem = (Users)_chatView.lsbAllUsers.SelectedItem;

        //        // Thêm mục đã chọn vào danh sách BidingList mới
        //        memberSelection.Add(selectedItem);

        //        // Xóa mục đã chọn khỏi danh sách BidingList cũ
        //        _chatView.lstMembers.Remove(selectedItem);

        //        // Gán ValueMember và DisplayMember trước khi gán DataSource
        //        _chatView.lsbMember.ValueMember = "strUserLogin";
        //        _chatView.lsbMember.DisplayMember = "strNameStaff";

        //        // Gán DataSource cho lsbMember từ danh sách các mục trong memberSelection
        //        _chatView.lsbMember.DataSource = memberSelection;
        //        _chatView.txtSearchMember.Text = string.Empty;
        //    }
        //}
        */
        #endregion

        #region Methods
        public void Run()
        {
            Application.Run(_chatView as ChatView);
        }

        private async void GetDataChatList()
        {
            chatList = await _chatRepository.GetListChat(strUserLogin: _chatView.UserLoginID);
            chatListBidingSource.DataSource = chatList;
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            //_chatView.lstbChat.Invoke((MethodInvoker)(() => _chatView.lstbChat.Items.Add(_chatView.strNameStaff + ": " + message)));
            AddDataToPanel();
        }

        private void AddDataToPanel()
        {
            _chatView.lstContent = _chatRepository.GetContent(senderID: _chatView.UserLoginID, receiverID: _chatView.ReceiverID).Result as BindingList<HistoriesChat>;

            _chatView.pnChat.Controls.Clear();

            if (_chatView.lstContent != null)
            {
                foreach (var item in _chatView.lstContent)
                {
                    if (item.SenderID == _chatView.UserLoginID)
                    {
                        AddMessageSend(item.StrContent);
                    }
                    else
                    {
                        AddMessageReceive(item.StrContent);
                    }
                }
                _chatView.pnChat.AutoScrollPosition = new Point(0, _chatView.pnChat.VerticalScroll.Maximum);
                _log.Info("Create button list and add textbox to panel.");
            }
            else
            {
                _log.Error("_chatView.lstContent is null.");
            }
            curTop = 10;
        }

        private void AddMessageSend(string message)
        {
            var bubble = new Controls.BoxSend();
            _chatView.pnChat.Controls.Add(bubble);
            //bubble.Dock = DockStyle.Top;
            //bubble.BringToFront();
            bubble.Message = message;

            bubble.Top = curTop;
            bubble.Width = _chatView.pnChat.Width - 30;
            curTop += bubble.Height;
        }

        private void AddMessageReceive(string message)
        {
            var bubble = new Controls.BoxReceive();
            _chatView.pnChat.Controls.Add(bubble);
            //bubble.BringToFront();
            //bubble.Dock = DockStyle.Top;
            bubble.Message = message;

            bubble.Top = curTop;
            bubble.Width = _chatView.pnChat.Width - 30;
            curTop += bubble.Height;
        }
        #endregion
    }
}
