using System;

namespace chat_app.Models
{
    public class ChatList
    {
        private int _id;
        private string _strNameStaff;
        private string _strAvartar;
        private string _strContent;
        private int _typeChat;
        private DateTime _timeSend;

        public int Id { get => _id; set => _id = value; }
        public string StrNameStaff { get => _strNameStaff; set => _strNameStaff = value; }
        public string StrAvartar { get => _strAvartar; set => _strAvartar = value; }
        public string StrContent { get => _strContent; set => _strContent = value; }
        public DateTime TimeSend { get => _timeSend; set => _timeSend = value; }
        public int TypeChat { get => _typeChat; set => _typeChat = value; }
    }
}
