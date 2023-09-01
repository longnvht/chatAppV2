using chat_app.Models.Interfaces;
using chat_app.Presenters;
using chat_app.Repositorys;
using chat_app.Utils;
using chat_app.Views.Interfaces;
using System;
using System.Windows.Forms;
using Unity;

namespace chat_app
{
    internal static class ConfigUnity
    {
        public static UnityContainer unityContainer { get; private set; } = new UnityContainer();
        public static void Register()
        {
            unityContainer.RegisterSingleton<ILoginView, Views.LoginView>();
            unityContainer.RegisterSingleton<IChatRepository, ChatRepository>();

            unityContainer.RegisterSingleton<IChatView, ChatView>();
            unityContainer.RegisterSingleton<IChatRepository, ChatRepository>();
        }
    }

    internal static class Program
    {
        public static Session sessionLogin = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChatView());
            //ConfigUnity.Register();
            //var loginPresenter = ConfigUnity.unityContainer.Resolve<LoginPresenter>();
            //loginPresenter.Run();
        }
    }
}
