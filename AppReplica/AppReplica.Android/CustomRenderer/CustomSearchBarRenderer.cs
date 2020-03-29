using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AppReplica.Experiment.CustomControl.CustomSearchBar), typeof(AppReplica.Droid.CustomRenderer.CustomSearchBarRenderer))]
namespace AppReplica.Droid.CustomRenderer
{

    public class CustomSearchBarRenderer : SearchBarRenderer
    {

        public CustomSearchBarRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Get native control (background set in shared code, but can use SetBackgroundColor here)
                SearchView searchView = (base.Control as SearchView);


                #region Remove Bottom Border of SearchView
                int viewId = searchView.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
                Android.Views.View view = (searchView.FindViewById(viewId) as Android.Views.View);
                view.SetBackgroundColor(Android.Graphics.Color.Transparent);    //Removing bottom border
                #endregion

                // Access search textview within control
                int textViewId = searchView.Context.Resources.GetIdentifier("android:id/search_src_text", null, null);
                EditText textView = (searchView.FindViewById(textViewId) as EditText);

                //Magnifier Icon for Searching
                int searchMagIcon = searchView.Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null);
                ImageView magIcon = (ImageView)searchView.FindViewById(searchMagIcon);
                //magIcon.SetColorFilter(Android.Graphics.Color.Rgb(255, 255, 255));
                //magIcon.Visibility = ViewStates.Gone;
                magIcon.SetImageResource(Resource.Drawable.WhatsAppBackButton);     //change the search icon to back icon :-P

                //// Customize frame color
                //int frameId = searchView.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
                //Android.Views.View frameView = (searchView.FindViewById(frameId) as Android.Views.View);
                //frameView.SetBackgroundColor(Android.Graphics.Color.Rgb(96, 96, 96));
            }

        }
    }
}