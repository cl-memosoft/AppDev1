using AppDev1.Services;
using AppDev1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDev1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new HomePage();
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
