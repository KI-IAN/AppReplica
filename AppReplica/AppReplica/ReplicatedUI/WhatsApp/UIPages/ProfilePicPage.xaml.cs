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
    public partial class ProfilePicPage : ContentPage
    {
        public ProfilePicPage()
        {
            InitializeComponent();
        }

        public ProfilePicPage(ViewModels.ProfilePicViewModel data)
        {
            InitializeComponent();

            this.BindingContext = data;
        }

        protected override void OnDisappearing()
        {
            //When this page is closed using soft back button on Navigation Bar, change the Bar Background color back to default color
            App.NavPage.BarBackgroundColor = Color.FromHex("#128C7E");

            base.OnDisappearing();

        }

    }
}