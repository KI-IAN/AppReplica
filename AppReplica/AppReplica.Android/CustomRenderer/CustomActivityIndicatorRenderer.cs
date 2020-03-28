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

[assembly: ExportRenderer(typeof(AppReplica.Experiment.CustomControl.CustomActivityIndicator), typeof(AppReplica.Droid.CustomRenderer.CustomActivityIndicatorRenderer))]
namespace AppReplica.Droid.CustomRenderer
{
    class CustomActivityIndicatorRenderer : ProgressBarRenderer
    {

        public CustomActivityIndicatorRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.
            }

        }

    }
}