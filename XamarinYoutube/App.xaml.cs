using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinYoutube.Views;

namespace XamarinYoutube
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeTabbedPage()) { BarBackgroundColor = Color.FromHex("#282828") };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
