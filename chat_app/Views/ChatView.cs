using chat_app.Models;
using chat_app.Views.Interfaces;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ChatList = chat_app.Models.ChatList;

namespace chat_app
{
    public partial class ChatView : Form, IChatView
    {
        public ChatView()
        {
            InitializeComponent();
            this.Load += delegate { ChatView_Load?.Invoke(this, EventArgs.Empty); };
            _btnSend.Click += delegate { btnSend_Click?.Invoke(this, EventArgs.Empty); };
            this.Resize += delegate { ChatView_Resize?.Invoke(this, EventArgs.Empty); };
            _txtMessage.TextChanged += delegate { txtMessage_TextChanged?.Invoke(this, EventArgs.Empty); };
            _chatList.ItemClicked += (s, e) =>
            {
                itemChatList_Click?.Invoke(s, e);
            };
            _btnAddMember.Click += (s, e) =>
            {
                _btnSelect.Enabled = false;
                _btnAddMember.Enabled = false;
                typeBtnSelect = 1;
                btnAddMember_Click?.Invoke(this, EventArgs.Empty);
            };
            _btnDeleteMember.Click += (s, e) =>
            {
                if (listMembers.Count <= 3)
                {
                    MessageBox.Show("Số lượng thành viên đã đạt mức tối thiểu, không thể xóa!");
                }
                else
                {
                    _btnDeleteMember.Enabled = false;
                    btnDeleteMember_Click?.Invoke(this, EventArgs.Empty);
                }
            };
            _lsbMembers.SelectedIndexChanged += (s, e) =>
            {
                if (_lsbMembers.SelectedIndex != -1)
                {
                    _btnDeleteMember.Enabled = true;
                }
                else
                {
                    _btnDeleteMember.Enabled = false;
                }
            };
            _btnSelect.Click += (s, e) =>
            {
                _txtSearchMember.Text = string.Empty;
                _grbMembers.Visible = false;
                if (typeBtnSelect == 0)
                {
                    SelectNewChat();
                }
                else
                {
                    SelectMemberGroup();
                }
                btnSelect_Click?.Invoke(this, EventArgs.Empty);
            };
            _btnCancel.Click += delegate { btnCancel_Click?.Invoke(this, EventArgs.Empty); };
            _lsMembers.ItemClick += (s, e) =>
            {
                Users user = _lsMembers.DataSource.Current as Users;
                if (user != null)
                {
                    _btnSelect.Enabled = true;
                    memberID = user.iID;
                    memberName = user.strNameStaff;
                }
            };
            _txtSearchMember.TextChanged += delegate { txtSearchMember_TextChanged?.Invoke(this, EventArgs.Empty); };
            _txtNewChat.Click += (s, e) =>
            {
                _btnSelect.Enabled = false;
                typeBtnSelect = 0;
                txtNewChat_Click?.Invoke(this, EventArgs.Empty);
            };
        }

        #region Properties - Fields
        public Guna2TextBox txtMessage { get => _txtMessage; set => _txtMessage = value; }
        public BindingList<HistoriesChat> lstContent { get; set; }
        public string strUserLogin { get; set; }
        public string strNameStaff { get; set; }
        public int UserLoginID { get; set; }
        public int ReceiverID { get; set; }
        public int TypeChat { get; set; }
        public Panel pnChat { get => _pnChat; set => _pnChat = value; }
        public char statusForm { get; set; }
        public ListBox lsbMembers { get => _lsbMembers; set => _lsbMembers = value; }
        public int memberID { get; set; }
        public string memberName { get; set; }
        public BindingList<ChatList> listMembers { get; set; }
        public Guna2TextBox txtNameChat { get => _txtNameChat; set => _txtNameChat = value; }
        public Guna2TextBox txtSearchMember { get => _txtSearchMember; set => _txtSearchMember = value; }
        public int typeBtnSelect { get; set; }
        #endregion

        #region Events
        public event EventHandler ChatView_Load;
        public event EventHandler btnSend_Click;
        public event EventHandler ChatView_Resize;
        public event EventHandler txtMessage_TextChanged;
        public event EventHandler itemChatList_Click;
        public event EventHandler btnAddMember_Click;
        public event EventHandler btnDeleteMember_Click;
        public event EventHandler btnSelect_Click;
        public event EventHandler btnCancel_Click;
        public event EventHandler txtSearchMember_TextChanged;
        public event EventHandler txtNewChat_Click;
        #endregion

        #region Methods

        /* Code cũ
        public Guna2GradientButton CreateButton(int? iIndex = null)
        {
            Guna2GradientButton btn = new Guna2GradientButton
            {
                Animated = true,
                BorderRadius = 10
            };
            btn.BorderThickness = 1;
            btn.BorderColor = System.Drawing.Color.FromArgb(70, 71, 117);
            btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btn.FillColor = System.Drawing.Color.WhiteSmoke;
            btn.FillColor2 = System.Drawing.Color.WhiteSmoke;
            btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(238, 238, 255);
            btn.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(148, 111, 207);
            btn.Font = new System.Drawing.Font("Segoe UI", 8F);
            btn.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btn.Margin = new System.Windows.Forms.Padding(5);
            btn.Location = new System.Drawing.Point(3, 3);
            btn.Size = new System.Drawing.Size(200, 50);

            // Tạo thành viên
            //if (_tclChat.SelectedIndex == 0)
            //{
            if (iIndex != null)
            {
                btn.Tag = this.lstUsers.Values.ElementAt(iIndex.Value).Keys.ElementAt(0);

                string strUserLogin = this.lstUsers.Values.ElementAt(iIndex.Value).Keys.ElementAt(0);
                string strNameStaff = this.lstUsers.Values.ElementAt(iIndex.Value).Values.ElementAt(0);
                btn.Text = strUserLogin + "\r\n" + strNameStaff;
            }
            btn.Click += (s, e) => { btnflpUser_Click?.Invoke(s, e); };
            //}
            //else if (_tclChat.SelectedIndex == 1) // Tạo nhóm
            //{
            //if (iIndex != null)
            //{
            //    btn.Tag = this.lstGroups.Keys.ElementAt(iIndex.Value);

            //    string strGroupID = this.lstGroups.Keys.ElementAt(iIndex.Value).ToString();
            //    string strGroupName = this.lstGroups.Values.ElementAt(iIndex.Value);
            //    btn.Text = strGroupID + "\r\n" + strGroupName;
            //}
            //btn.Click += (s, e) => { btnflpGroup_Click?.Invoke(s, e); };
            //}
            return btn;
        }

        public Guna2TextBox CreateTextBox(string strUserLoginFrom = "", string strContent = "")
        {
            Guna2TextBox tb = new Guna2TextBox
            {
                Animated = true,
                BorderRadius = 10
            };
            var strContentLeght = strContent.Length;
            tb.ReadOnly = true;
            tb.Font = new System.Drawing.Font("Segoe UI", 8F);
            tb.Multiline = true;
            tb.Dock = DockStyle.Top;
            tb.Text = strContent;
            if (strUserLoginFrom == this.strUserLogin)
            {
                tb.TextAlign = HorizontalAlignment.Right;
            }
            else
            {
                tb.TextAlign = HorizontalAlignment.Left;
            }
            return tb;
        }

        public void SetCheckedButton()
        {
            // Set checked User
            if (_tclChat.SelectedIndex == 0)
            {
                if (_flpListUser.Controls.Count > 0)
                {
                    foreach (Control item in _flpListUser.Controls)
                    {
                        Guna2GradientButton btn = (Guna2GradientButton)item;
                        if ((item.GetType() != typeof(Guna2GradientButton)))
                        {
                            continue;
                        }
                        if (btn.Checked)
                        {
                            btn.Checked = false;
                            return;
                        }
                    }
                }
            }
            else if (_tclChat.SelectedIndex == 1) // Set cheked nhóm
            {
                if (_flpListGroup.Controls.Count > 0)
                {
                    foreach (Control item in _flpListGroup.Controls)
                    {
                        Guna2GradientButton btn = (Guna2GradientButton)item;
                        if ((item.GetType() != typeof(Guna2GradientButton)))
                        {
                            continue;
                        }
                        if (btn.Checked)
                        {
                            btn.Checked = false;
                            return;
                        }
                    }
                }
            }
        }
        */

        public void SetDataSourceChatList(BindingSource chatListBidingSource)
        {
            _chatList.DataSource = chatListBidingSource;
        }

        public void SetDataSourceListMembers(BindingSource listMembersBidingSource)
        {
            _lsMembers.DataSource = listMembersBidingSource;
        }

        public void SetStatusForm()
        {
            switch (statusForm)
            {
                case '1':
                    _pnDetail.Visible = true;
                    _pnDetail.Dock = DockStyle.Right;
                    _pnDetail.SendToBack();
                    if (TypeChat == 0)
                    {
                        _btnDeleteMember.Enabled = false;
                    }
                    else
                    {
                        _btnDeleteMember.Enabled = true;
                    }
                    break;
                case '2':
                    _grbMembers.Visible = true;
                    _grbMembers.Dock = DockStyle.Right;
                    break;
                case '3':
                    _grbMembers.Visible = false;
                    break;
            }
        }

        private void SelectMemberGroup()
        {
            _btnAddMember.Enabled = true;
            ChatList dataMember = new ChatList
            {
                Id = memberID,
                StrNameStaff = memberName
            };

            if (!listMembers.Any(item => item.Id == dataMember.Id))
            {
                listMembers.Add(dataMember);
            }
            else
            {
                MessageBox.Show("Thành viên đã tồn tại trong nhóm!");
                return;
            }
            _txtNameChat.Text = string.Empty;
            if (string.IsNullOrEmpty(_txtNameChat.Text) || string.IsNullOrWhiteSpace(_txtNameChat.Text))
            {
                _txtNameChat.Text = string.Empty;
                foreach (var item in listMembers)
                {
                    _txtNameChat.Text += item.StrNameStaff + ", ";
                }
                if (!string.IsNullOrEmpty(_txtNameChat.Text))
                {
                    char[] trimChars = { ',', ' ' };
                    _txtNameChat.Text = _txtNameChat.Text.TrimEnd(trimChars);
                }
            }
        }

        private void SelectNewChat()
        {
            ChatList dataMember = new ChatList
            {
                Id = memberID,
                StrNameStaff = memberName
            };
        }
        #endregion
    }
}
