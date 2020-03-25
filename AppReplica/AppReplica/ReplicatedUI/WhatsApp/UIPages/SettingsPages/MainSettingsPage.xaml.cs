using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppReplica.ReplicatedUI.WhatsApp.UIPages.SettingsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainSettingsPage : ContentPage
    {
        public MainSettingsPage()
        {
            InitializeComponent();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int totalSelectedItem = e.CurrentSelection.Count;


            if (totalSelectedItem > 0 && this.ToolbarItems.Count <= 0)
            {
                AddToolBarItem();
            }


            if (totalSelectedItem > 0)
            {

                this.Title = $"{totalSelectedItem}";

            }
            else
            {
                this.ToolbarItems.Clear();
                this.Title = $"Settings";
            }
        }


        private void AddToolBarItem()
        {

            List<ToolbarItem> toolbarItems = new List<ToolbarItem>()
            {
                new ToolbarItem(){
                    Text = "Pin Chat",
                    IconImageSource="WhatsAppChatPinned.png",
                },

                new ToolbarItem(){
                    Text = "Delete Chat",
                    IconImageSource = "WhatsAppDelete.png",
                },

                new ToolbarItem(){
                    Text = "Mute Chat",
                    IconImageSource = "WhatsAppMuteNotification.png",
                },

                new ToolbarItem(){
                    Text = "Archive Chat",
                    IconImageSource = "WhatsAppArchieve.png",
                },
            };


            foreach (var item in toolbarItems)
            {
                this.ToolbarItems.Add(item);
            }

        }

    }
}