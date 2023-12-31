using BeautyHall.Api.SDK;
using BeautyHall.Api.SDK.Interfaces;
using BeautyHall.Api.SDK.Configuration;
using DevExpress.LookAndFeel;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace BSMS
{
    public static class Program
    {
        public static IBeautyHallApiSDK ApiSdk = null!;
        public static Login login = new();
        public static Dashboard dashboard = null!;
        public static string? OrderReportPath = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();
            var baseUrl = config.GetValue<string>("Api:BaseUrl");
            var dxSkinPalette = config.GetValue<string>("DXSkin:SkinPalette");
            var dxPaletteName = config.GetValue<string>("DXSkin:PaletteName");
            OrderReportPath = config.GetValue<string>("Reports:OrderReportPath");

            UserLookAndFeel.Default.SetSkinStyle(dxSkinPalette, dxPaletteName);

            ApiSdk = new BeautyHallApiSDK(new BeautyHallApiSDKConfiguration
            {
                 BaseUrl = baseUrl
            });

            Application.Run(login);
        }
    }
}