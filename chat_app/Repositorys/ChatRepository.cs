using chat_app.Models;
using chat_app.Models.Interfaces;
using chat_app.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace chat_app.Repositorys
{
    public class ChatRepository : IChatRepository
    {
        private readonly static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ChatRepository).Name);

        public async Task<bool> AddGroup(string strNameGroup)
        {
            if (string.IsNullOrEmpty(strNameGroup) || string.IsNullOrEmpty(strNameGroup))
            {
                _log.Info("Parameter is Null!");
                return false;
            }

            string strCmdProcedure = @"AddGroup";
            _log.Info("Store procedure add history chat: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_strNameGroup",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strNameGroup,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> AddHistoryChat(int senderID, int receiverID, string strContent)
        {
            if (string.IsNullOrEmpty(strContent) || string.IsNullOrWhiteSpace(strContent))
            {
                _log.Info("Parameter is Null!");
                return false;
            }

            string strCmdProcedure = @"AddHistoryChat";
            _log.Info("Store procedure add history chat: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_senderID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = senderID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_receiverID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = receiverID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_strContent",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strContent,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> AddMemberNewGroup(int memberGroupID)
        {
            string strCmdProcedure = @"AddMemberNewGroup";
            _log.Info("Store procedure add history chat: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_MemberGroupID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = memberGroupID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> DeleteGroup(int groupID)
        {
            string strCmdProcedure = @"DeleteGroup";
            _log.Info("Store procedure delete group: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_GroupID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = groupID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<HistoriesChat>> GetContent(int SenderID, int ReceiverID)
        {
            BindingList<HistoriesChat> lstContent = null;

            string strQueryProcedure = @"GetContent";
            _log.Info("Store procedure query get content in table HistoriesChat: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_SenderID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = SenderID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_ReceiverID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = ReceiverID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                };

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstContent == null)
                            {
                                lstContent = new BindingList<HistoriesChat>();
                            }

                            HistoriesChat historiesChat = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                historiesChat = new HistoriesChat();

                                if (historiesChat != null)
                                {
                                    if (!await mySqlDataReader.IsDBNullAsync(0)) // SenderID
                                    {
                                        historiesChat.SenderID = Convert.ToInt32(mySqlDataReader["SenderID"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(1)) // Content
                                    {
                                        historiesChat.StrContent = mySqlDataReader["Content"].ToString();
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(2)) // TimeSend
                                    {
                                        historiesChat.DtTimeSend = Convert.ToDateTime(mySqlDataReader["TimeSend"]);
                                    }
                                }
                                lstContent.Add(historiesChat);
                            }

                            mySqlDataReader.Close();
                        }
                        else
                        {
                            _log.Info("mySqlDataReader is null.");
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstContent;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public async Task<Dictionary<int?, string>> GetListGroups(string strUserFrom)
        {
            if (string.IsNullOrEmpty(strUserFrom) || string.IsNullOrWhiteSpace(strUserFrom))
            {
                _log.Info("Parameter is Null!");
                return null;
            }
            Dictionary<int?, string> lstGroup = null;
            string strQueryProcedure = @"GetListGroups";

            _log.Info("Store procedure query: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserFrom,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var item in lstPar)
                {
                    if (item.Value == DBNull.Value)
                    {
                        return null;
                    }
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstGroup == null)
                            {
                                lstGroup = new Dictionary<int?, string>();
                            }
                            List<string> lstGroupName = null;

                            while (await mySqlDataReader.ReadAsync())
                            {
                                lstGroupName = new List<string>();

                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    lstGroupName.Add(mySqlDataReader.GetString(1));
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstGroup.Add(mySqlDataReader.GetInt32(0), lstGroupName.ElementAt(0));
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    mySqlConnection.Close();
                }
                return lstGroup;
            }
            catch (MySqlException e)
            {

                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Users>> GetListMembers(int userLoginID)
        {
            BindingList<Users> lstMembers = null;

            string strQueryProcedure = @"GetListMembers";
            _log.Info("Store procedure query get user in table Users: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_UserLoginID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = userLoginID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstMembers == null)
                            {
                                lstMembers = new BindingList<Users>();
                            }

                            Users user = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                user = new Users();

                                if (user != null)
                                {

                                    if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                    {
                                        user.iID = Convert.ToInt32(mySqlDataReader["ID"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(1)) // UserLogin
                                    {
                                        user.strUserLogin = mySqlDataReader["UserLogin"].ToString();
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(2)) // NameStaff
                                    {
                                        user.strNameStaff = mySqlDataReader["NameStaff"].ToString();
                                    }
                                }
                                lstMembers.Add(user);
                            }

                            mySqlDataReader.Close();
                        }
                        else
                        {
                            _log.Info("mySqlDataReader is null.");
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstMembers;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public async Task<Dictionary<int?, Dictionary<string, string>>> GetListUsers(string strUserFrom)
        {
            if (string.IsNullOrEmpty(strUserFrom) || string.IsNullOrWhiteSpace(strUserFrom))
            {
                _log.Info("Parameter is Null!");
                return null;
            }
            Dictionary<int?, Dictionary<string, string>> lstUsers = null;
            string strQueryProcedure = @"GetListUsers";

            _log.Info("Store procedure query: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserFrom,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var item in lstPar)
                {
                    if (item.Value == DBNull.Value)
                    {
                        return null;
                    }
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstUsers == null)
                            {
                                lstUsers = new Dictionary<int?, Dictionary<string, string>>();
                            }
                            Dictionary<string, string> lstUserLoginNameStaff = null;

                            while (await mySqlDataReader.ReadAsync())
                            {
                                lstUserLoginNameStaff = new Dictionary<string, string>();

                                if (!await mySqlDataReader.IsDBNullAsync(1) && !await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    lstUserLoginNameStaff.Add(mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstUsers.Add(mySqlDataReader.GetInt32(0), lstUserLoginNameStaff);
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    mySqlConnection.Close();
                }
                return lstUsers;
            }
            catch (MySqlException e)
            {

                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<Users> GetUserLogin(string strUserName, string strPassword)
        {
            if (string.IsNullOrEmpty(strUserName) || string.IsNullOrEmpty(strPassword))
            {
                _log.Info("UserName or Password is Null!");
                return null;
            }

            Users userAccount = null;
            string strQueryProcedure = @"GetUserLogin";
            _log.Info("Store procedure query get user account: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserName,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Pass",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strPassword,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var item in lstPar)
                {
                    if (item.Value == DBNull.Value)
                    {
                        return null;
                    }
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (userAccount == null)
                            {
                                userAccount = new Users();
                            }

                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                {
                                    userAccount.iID = mySqlDataReader.GetInt32(0);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(1)) // UserLogin
                                {
                                    userAccount.strUserLogin = mySqlDataReader.GetString(1);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(2)) // Pass
                                {
                                    userAccount.strPass = mySqlDataReader.GetString(2);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(3)) // NameStaff
                                {
                                    userAccount.strNameStaff = mySqlDataReader.GetString(3);
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return userAccount;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        // Từ chỗ này là code viết mới

        public async Task<IEnumerable<ChatList>> GetListChat(int strUserLogin)
        {
            BindingList<ChatList> lstChat = null;

            string strQueryProcedure = @"GetListChat";
            _log.Info("Store procedure query get content in table HistoriesChat: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_strUserLogin",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = strUserLogin,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstChat == null)
                            {
                                lstChat = new BindingList<ChatList>();
                            }

                            ChatList users = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                users = new ChatList();

                                if (users != null)
                                {
                                    if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                    {
                                        users.Id = Convert.ToInt32(mySqlDataReader["ID"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(1)) // NameStaff
                                    {
                                        users.StrNameStaff = mySqlDataReader["NameStaff"].ToString();
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(2)) // Avartar
                                    {
                                        users.StrAvartar = mySqlDataReader["Avartar"].ToString();
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(3)) // Content
                                    {
                                        users.StrContent = mySqlDataReader["Content"].ToString();
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(4)) // TypeChat
                                    {
                                        users.TypeChat = Convert.ToInt32(mySqlDataReader["TypeChat"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(5)) // TimeSend
                                    {
                                        users.TimeSend = Convert.ToDateTime(mySqlDataReader["TimeSend"]);
                                    }
                                }
                                lstChat.Add(users);
                            }

                            mySqlDataReader.Close();
                        }
                        else
                        {
                            _log.Info("mySqlDataReader is null.");
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstChat;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public async Task<BindingList<ChatList>> GetChatMembers(int senderID, int receiverID)
        {
            BindingList<ChatList> lstChat = null;

            string strQueryProcedure = @"GetChatMembers";
            _log.Info("Store procedure query get ID and Name in table Users: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_SenderID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = senderID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_ReceiverID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = receiverID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstChat == null)
                            {
                                lstChat = new BindingList<ChatList>();
                            }

                            ChatList users = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                users = new ChatList();

                                if (users != null)
                                {
                                    if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                    {
                                        users.Id = Convert.ToInt32(mySqlDataReader["ID"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(1)) // NameStaff
                                    {
                                        users.StrNameStaff = mySqlDataReader["NameStaff"].ToString();
                                    }
                                }
                                lstChat.Add(users);
                            }

                            mySqlDataReader.Close();
                        }
                        else
                        {
                            _log.Info("mySqlDataReader is null.");
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstChat;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public async Task<BindingList<ChatList>> GetGroupMembers(int groupID)
        {
            BindingList<ChatList> lstChat = null;

            string strQueryProcedure = @"GetGroupMembers";
            _log.Info("Store procedure query get ID and Name in table Users: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_GroupID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = groupID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstChat == null)
                            {
                                lstChat = new BindingList<ChatList>();
                            }

                            ChatList users = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                users = new ChatList();

                                if (users != null)
                                {
                                    if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                    {
                                        users.Id = Convert.ToInt32(mySqlDataReader["ID"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(1)) // NameStaff
                                    {
                                        users.StrNameStaff = mySqlDataReader["NameStaff"].ToString();
                                    }
                                }
                                lstChat.Add(users);
                            }

                            mySqlDataReader.Close();
                        }
                        else
                        {
                            _log.Info("mySqlDataReader is null.");
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstChat;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public async Task<bool> AddMessageNewGroup(int senderID, string strContent)
        {
            string strCmdProcedure = @"AddMessageNewGroup";
            _log.Info("Store procedure add history chat: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_senderID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = senderID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_strContent",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strContent,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> AddMemberGroup(int groupID, int memberGroupID)
        {
            string strCmdProcedure = @"AddMemberGroup";
            _log.Info("Store procedure add history chat: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_GroupID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = groupID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_MemberID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = memberGroupID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> DeleteMember(int groupID, int memberID)
        {
            string strCmdProcedure = @"DeleteMember";
            _log.Info("Store procedure add history chat: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_GroupID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = groupID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_MemberID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = memberID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Add WorkingTransaction Successfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<IEnumerable<Users>> GetListNewChat(int userLoginID)
        {
            BindingList<Users> lstMembers = null;

            string strQueryProcedure = @"GetListNewChat";
            _log.Info("Store procedure query get user in table Users: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_UserLoginID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = userLoginID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstMembers == null)
                            {
                                lstMembers = new BindingList<Users>();
                            }

                            Users user = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                user = new Users();

                                if (user != null)
                                {

                                    if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                    {
                                        user.iID = Convert.ToInt32(mySqlDataReader["ID"]);
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(1)) // UserLogin
                                    {
                                        user.strUserLogin = mySqlDataReader["UserLogin"].ToString();
                                    }

                                    if (!await mySqlDataReader.IsDBNullAsync(2)) // NameStaff
                                    {
                                        user.strNameStaff = mySqlDataReader["NameStaff"].ToString();
                                    }
                                }
                                lstMembers.Add(user);
                            }

                            mySqlDataReader.Close();
                        }
                        else
                        {
                            _log.Info("mySqlDataReader is null.");
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstMembers;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }
    }
}