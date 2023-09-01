using chat_app.Views.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Models
{
    public class MessageItemModel
    {
        public int Id { get; set; }
        public MessageType MessageType { get; set; }
        public string MessageContent { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set;}
        public DateTime SendDate { get; set; }
        public bool Status { get; set; }    
    }
}
