using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            // MainPage = new MainPage();
            // MainPage = new DetailPage();
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
