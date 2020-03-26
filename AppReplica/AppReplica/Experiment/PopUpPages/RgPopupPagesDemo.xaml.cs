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
    public partial class RgPopupPagesDemo : Rg.Plugins.Popup.Pages.PopupPage
    {
        public RgPopupPagesDemo()
        {
            InitializeComponent();
        }
    }
}