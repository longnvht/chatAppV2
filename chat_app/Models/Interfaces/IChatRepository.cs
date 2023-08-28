using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace chat_app.Models.Interfaces
{
    public interface IChatRepository
    {
        Task<bool> AddGroup(string strNameGroup);
        Task<bool> AddHistoryChat(int senderID, int receiverID, string strContent);
        Task<bool> AddMemberNewGroup(int memberGroupID);
        Task<bool> DeleteGroup(int groupID);
        Task<IEnumerable<HistoriesChat>> GetContent(int senderID, int receiverID);
        Task<Dictionary<int?, string>> GetListGroups(string strUserFrom);
        Task<IEnumerable<Users>> GetListMembers(int userLoginID);
        Task<Dictionary<int?, Dictionary<string, string>>> GetListUsers(string strUserFrom);
        Task<Users> GetUserLogin(string strUserName, string strPassword);

        // Từ chỗ này là code viết mới
        Task<IEnumerable<ChatList>> GetListChat(int strUserLogin);
        Task<BindingList<ChatList>> GetChatMembers(int senderID, int receiverID);
        Task<BindingList<ChatList>> GetGroupMembers(int groupID);
        Task<bool> AddMessageNewGroup(int senderID, string strContent);
        Task<bool> AddMemberGroup(int groupID, int memberGroupID);
        Task<bool> DeleteMember(int groupID, int memberID);
        Task<IEnumerable<Users>> GetListNewChat(int userLoginID);
    }
}
