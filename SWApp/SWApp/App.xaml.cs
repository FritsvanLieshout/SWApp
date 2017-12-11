using Xamarin.Forms;

namespace SWApp
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new MainPage())
                {
                    //BarBackgroundColor = Color.FromHex("#0080FF"),
                    //BarTextColor = Color.White,
                };
            }
            else
            {
                MainPage = new NavigationPage(new SWApp.MainPage())
                {
                   // BarBackgroundColor = Color.FromHex("#fff3f3f3"),
                   // BarTextColor = Color.Black,
                };
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
