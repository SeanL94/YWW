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
    [Activity(Label = "comm_Advice_Main")]
    public class comm_Advice_Main : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_advice_main);

            Button newPostbtn = FindViewById<Button>(Resource.Id.newPostBtn);
            newPostbtn.Click += delegate {
                StartActivity(typeof(comm_Sharing_Main));
            };

            Button bkBtn = FindViewById<Button>(Resource.Id.bkBtn);
            bkBtn.Click += delegate {
                StartActivity(typeof(comm_Sharing_Main));
            };
        }
    }
}