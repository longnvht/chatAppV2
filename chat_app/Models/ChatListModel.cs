using System;

namespace chat_app.Models
{
    public class ChatListModel
    {
        private int _partnerID;
        private string _partnerName;
        private string _partnerAvartar;
        private string _lastMessage;
        private int _typeChat;
        private DateTime _timeSend;

        public int PartnerID { get => _partnerID; set => _partnerID = value; }
        public string PartnerName { get => _partnerName; set => _partnerName = value; }
        public string PartnerAvartar { get => _partnerAvartar; set => _partnerAvartar = value; }
        public string LastMessage { get => _lastMessage; set => _lastMessage = value; }
        public int TypeChat { get => _typeChat; set => _typeChat = value; }
        public DateTime TimeSend { get => _timeSend; set => _timeSend = value; }
    }
}
