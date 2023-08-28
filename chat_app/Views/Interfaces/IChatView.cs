using chat_app.Models;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace chat_app.Views.Interfaces
{
    public interface IChatView
    {
        #region Properties - Fields
        string strUserLogin { get; set; }
        string strNameStaff { get; set; }
        int UserLoginID { get; set; }
        int ReceiverID { get; set; }
        int TypeChat { get; set; }
        int memberID { get; set; }
        int typeBtnSelect { get; set; }
        char statusForm { get; set; }
        Panel pnChat { get; set; }
        Guna2TextBox txtMessage { get; set; }
        BindingList<HistoriesChat> lstContent { get; set; }
        ListBox lsbMembers { get; set; }
        BindingList<ChatList> listMembers { get; set; }
        Guna2TextBox txtNameChat { get; set; }
        Guna2TextBox txtSearchMember { get; set; }
        #endregion

        #region Events
        event EventHandler ChatView_Load;
        event EventHandler btnSend_Click;
        event EventHandler ChatView_Resize;
        event EventHandler txtMessage_TextChanged;
        event EventHandler itemChatList_Click;
        event EventHandler btnAddMember_Click;
        event EventHandler btnDeleteMember_Click;
        event EventHandler btnSelect_Click;
        event EventHandler btnCancel_Click;
        event EventHandler txtSearchMember_TextChanged;
        event EventHandler txtNewChat_Click;
        #endregion

        #region Method
        void Show();
        //Guna2GradientButton CreateButton(int? iIndex = null);
        //Guna2TextBox CreateTextBox(string strUserLoginFrom = "", string strContent = "");
        //void Close();
        //void SetCheckedButton();
        void SetStatusForm();
        void SetDataSourceChatList(BindingSource chatListBidingSource);
        void SetDataSourceListMembers(BindingSource listMembersBidingSource);
        #endregion
    }
}
