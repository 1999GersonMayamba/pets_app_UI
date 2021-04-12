using pets_app_laura_gonzalez.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pets_app_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
