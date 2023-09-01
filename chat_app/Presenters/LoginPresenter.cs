using chat_app.Models;
using chat_app.Models.Interfaces;
using chat_app.Views;
using chat_app.Views.Interfaces;
using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using Unity;

namespace chat_app.Presenters
{
    public class LoginPresenter
    {
        public LoginPresenter(ILoginView loginView, IChatRepository chatRepository)
        {
            _loginView = loginView;
            _chatRepository = chatRepository;

            // Event handler methods to view events.
            _loginView.btnLogin_Click += _loginView_btnLogin_Click;
            _loginView.btnCancel_Click += _loginView_btnCancel_Click;
            _loginView.txtPassword_IconRightClick += _loginView_txtPassword_IconRightClick;

            _loginView.Show();
        }

        #region Fields
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(LoginPresenter).Name);

        private readonly ILoginView _loginView;
        private readonly IChatRepository _chatRepository;
        #endregion

        #region Events
        private void _loginView_btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _loginView_txtPassword_IconRightClick(object sender, EventArgs e)
        {
            var txtPassword = ((Guna2TextBox)sender);
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.IconRight = Properties.Resources.pass_hide_24px;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.IconRight = Properties.Resources.pass_show_24px;
            }
        }

        private async void _loginView_btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = _loginView.strUserName;
            string strPassword = Utils.Encryption.CreateMD5(_loginView.strPassword);
            _log.Info("Login with username: " + strUserName);
            try
            {
                // 1. Get ID, Add Session.
                if (Program.sessionLogin == null)
                {
                    Program.sessionLogin = new Utils.Session();
                }

                // 2. Get user account.
                Users userAccount = await _chatRepository.GetUserLogin(strUserName, strPassword);
                if (userAccount == null)
                {
                    MessageDialog.Show("Đăng Nhập Thất Bại!", "Thông báo", MessageDialogButtons.OK, MessageDialogIcon.Error);
                    _log.Info("Login Fail!");
                    return;
                }
                else
                {
                    if (userAccount.iID == 0)
                    {
                        MessageDialog.Show("Đăng Nhập Thất Bại!", "Thông báo", MessageDialogButtons.OK, MessageDialogIcon.Error);
                        _log.Info("Login Fail!");
                        return;
                    }
                    Program.sessionLogin["Id"] = userAccount.iID;
                    Program.sessionLogin["UserName"] = strUserName; // UserLogin
                    Program.sessionLogin["Password"] = strPassword;
                    Program.sessionLogin["Name"] = userAccount.strNameStaff;
                    Program.sessionLogin["PermissionId"] = userAccount.strPermissionId;
                    Program.sessionLogin["LoginTime"] = Utils.ServerTime.GetServerTime().ToLocalTime().ToString();

                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(
                            () =>
                            {
                                var chatPresenter = ConfigUnity.unityContainer.Resolve<ChatPresenter>();
                            }));

                    t.Start();

                    _log.Info("Login Success!");
                    _loginView.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _log.Error(ex.Message);
            }
        }
        #endregion

        #region Methods
        public void Run()
        {
            Application.Run(_loginView as LoginView);
        }
        #endregion
    }
}
