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
    [Activity(Label = "comm_Sharing_Main")]
    public class comm_Sharing_Main : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_sharing_main);


            Button newPostButton = FindViewById<Button>(Resource.Id.newThoughtsBtn);
            newPostButton.Click += delegate {
                StartActivity(typeof(FirstView));
            };
        }
    }
}