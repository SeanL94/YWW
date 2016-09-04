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
/**
 * Author Jia Xin Chan 9601902
 * 
 **/
namespace healthJourney.droid.Views
{
    [Activity(Label = "comm_Main")]
    public class comm_Main : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_main);
            
            Button healthBtn = FindViewById<Button>(Resource.Id.healthJourney);
            healthBtn.Click += delegate {
                StartActivity(typeof(FirstView));
            };
            Button profileBtn = FindViewById<Button>(Resource.Id.profile);
            profileBtn.Click += delegate {
                StartActivity(typeof(profile_main));
            };

            Button sharingBtn = FindViewById<Button>(Resource.Id.sharingBtn);
            sharingBtn.Click += delegate {
                StartActivity(typeof(comm_Sharing_Main));
            };

            Button adviceBtn = FindViewById<Button>(Resource.Id.adviceBtn);
            adviceBtn.Click += delegate {
                StartActivity(typeof(comm_Advice_Main));
            };
        }
    }
}