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
    public partial class ChatListPage : ContentPage
    {
        public ChatListPage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new NavigationPage(new SettingsPages.MainSettingsPage())
            //{
            //    BarBackgroundColor = Color.FromHex("#128C7E"),
            //});

            await Navigation.PushAsync(new SettingsPages.MainSettingsPage());
        }
    }
}