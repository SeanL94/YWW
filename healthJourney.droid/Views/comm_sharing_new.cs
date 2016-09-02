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

namespace healthJourney.droid.Views
{
    [Activity(Label = "comm_sharing_new")]
    public class comm_Sharing_New : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_sharing_new);

            Button cancelButton = FindViewById<Button>(Resource.Id.cancelBtn);
            cancelButton.Click += delegate {
                StartActivity(typeof(comm_Sharing_Main));
            };
        }
    }
}