using System;
using TimeTableKGU.Services;
using TimeTableKGU.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTableKGU
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
