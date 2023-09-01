using chat_app.Models;
using chat_app.Presenters;
using chat_app.Repositorys;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace chat_app.Views.Interfaces
{
    public interface IChatView
    {
        #region Properties - Fields
        ChatListModel CurrentChatList { get; set; }
        string CurrentMessage { get; set; } 
        List<Users> MemberGroup { get; set; }
        ChatPresenter Presenter { set; }
        string MessageText { get; set; }   

        #endregion

        #region Events
        event EventHandler ChatItemSelected;
        event EventHandler AddMessage;
        event EventHandler AddChatGroup;
        event EventHandler AddMemberToGroup;
        event EventHandler RemoveMemberFromGroup;

        #endregion

        #region Method
        void SetMessageListBindingSource(BindingSource mesageSource);
        void SetChatListBindingSource(BindingSource chatListBidingSource);
        void SetListMembersBindingSource(BindingSource listMembersBidingSource);
        #endregion
    }
}
