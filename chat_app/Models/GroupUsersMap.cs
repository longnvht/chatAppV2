using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Models
{
    public class GroupUsersMap
    {
        private int _iID;
        private int _groupID;
        private string _strUserLogin;

        public int iID { get => _iID; set => _iID = value; }
        public int groupID { get => _groupID; set => _groupID = value; }
        public string strUserLogin { get => _strUserLogin; set => _strUserLogin = value; }
    }
}
