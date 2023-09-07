using Microsoft.Maui.Controls;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Nutricion
{
    public partial class App : Application
    {
        public static Repository IMCrepository { get; set; }
        public App(Repository repository)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AppShell());

            AppCenter.Start("android=ed19a411-3841-4f8a-ac2c-b71b6378a986;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here};" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));

            IMCrepository = repository;
        }
    }
}