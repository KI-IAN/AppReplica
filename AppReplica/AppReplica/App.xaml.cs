using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppReplica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ReplicatedUI.WhatsApp.UIPages.SplashScreen();

            //MainPage = new NavigationPage(new ReplicatedUI.WhatsApp.UIPages.SettingsPages.MainSettingsPage())
            //{
            //    BarBackgroundColor = Color.FromHex("#128C7E"),
            //};

            //MainPage = new ReplicatedUI.WhatsApp.UIPages.SettingsPages.MainSettingsPage();

            MainPage = new Experiment.PopUpPages.TestPopupPage();

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
