using Siscord_Placord.Services;
using Siscord_Placord.ViewModels;
using Siscord_Placord.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Siscord_Placord
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
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
