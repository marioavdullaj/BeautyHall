using BeautyHall.Api.SDK;
using BeautyHall.Api.SDK.Interfaces;
using BeautyHall.Api.SDK.Configuration;
using DevExpress.LookAndFeel;
namespace Demo
{
    public static class Program
    {
        public static IBeautyHallApiSDK ApiSdk = new BeautyHallApiSDK(new BeautyHallApiSDKConfiguration
        {
            BaseUrl = "http://localhost:5000/",
            Timeout = 10000,
            MaxRetry = 5
        });
        public static Login login;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier", "Office Dark");

            login = new Login();
            Application.Run(login);
        }
    }
}