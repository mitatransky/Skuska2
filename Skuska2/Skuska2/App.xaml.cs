using Skuska2.Services;
using Skuska2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Skuska2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new StartPage();
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
