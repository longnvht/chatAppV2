using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Views.Interfaces
{
    public interface ILoginView
    {
        #region Properties - Fields
        string strUserName { get; set; }
        string strPassword { get; set; }
        #endregion

        #region Events
        event EventHandler btnLogin_Click;
        event EventHandler btnCancel_Click;
        event EventHandler txtPassword_IconRightClick;
        #endregion

        #region Methods
        void Show();
        void Close();
        void Hide();
        #endregion
    }
}
