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

            MainPage = new NavigationPage(new ReplicatedUI.WhatsApp.UIPages.MainTabbedPage())
            {
                BarBackgroundColor = Color.FromHex("#128C7E"),
               
            };
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
