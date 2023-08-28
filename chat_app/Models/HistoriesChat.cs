using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Models
{
    public class HistoriesChat
    {
        private int _iID;
        private int _senderID;
        private int _receiverID;
        private string _strContent;
        private DateTime _dtTimeSend;

        public int IID { get => _iID; set => _iID = value; }
        public int SenderID { get => _senderID; set => _senderID = value; }
        public int ReceiverID { get => _receiverID; set => _receiverID = value; }
        public string StrContent { get => _strContent; set => _strContent = value; }
        public DateTime DtTimeSend { get => _dtTimeSend; set => _dtTimeSend = value; }
    }
}
