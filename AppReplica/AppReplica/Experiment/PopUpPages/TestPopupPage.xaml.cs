using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppReplica.Experiment.PopUpPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPopupPage : ContentPage
    {
        public TestPopupPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new RgPopupPagesDemo());
            await PopupNavigation.Instance.PushAsync(new RgPopupPagesDemo());
        }
    }
}