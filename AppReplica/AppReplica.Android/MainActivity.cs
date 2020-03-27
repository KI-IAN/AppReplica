using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Drawing;
using Xamarin.Forms;
using Color = Xamarin.Forms.Color;

namespace AppReplica.Droid
{
    [Activity(Label = "AppReplica", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);


            #region Initialize RG.Plugins.Popup

            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);

            #endregion

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#075E54"));     //Change the Status Bar Color for Android

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        #region RG.Plugins.Popup Overrides OnBackPressed

        public override void OnBackPressed()
        {
            //Change the BarBackground color back to default color
            App.NavPage.BarBackgroundColor = Color.FromHex("#128C7E");


            if (Rg.Plugins.Popup.Popup.SendBackPressed(base.OnBackPressed))
            {
                //Do something if there are some pages in the PopupStack
            }
            else
            {
                //Do something if there ar not any pages in the PopupStack
            }

        }

        #endregion


    }
}