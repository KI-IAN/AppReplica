using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppReplica.ReplicatedUI.WhatsApp.UIPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(3 * 1000);     //just show a splash screen for few seconds to give user a feel that application is being loaded...

            await this.FadeTo(1, 1 * 10, Easing.Linear);        //Now fades out the splash screen quickly and jump to main screen

            Application.Current.MainPage = new UIPages.MainTabbedPage();      //Navigate to main page of the app

        }





    }
}