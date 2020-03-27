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
    public partial class ProfilePopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        #region Constructors

        public ProfilePopupPage()
        {
            InitializeComponent();
        }

        public ProfilePopupPage(ViewModels.ProfilePopupViewModel data)
        {
            InitializeComponent();

            this.BindingContext = data;
        }

        #endregion

    }
}