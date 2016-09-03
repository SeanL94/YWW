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
                StartActivity(typeof(comm_Advice_New));
            };

            Button bkBtn = FindViewById<Button>(Resource.Id.backBtn);
            bkBtn.Click += delegate {
                StartActivity(typeof(comm_Main));
            };

            LinearLayout topicLayout = FindViewById<LinearLayout>(Resource.Id.topicLayout1);
            topicLayout.Click += delegate {
                StartActivity(typeof(comm_Advice_Topic));
            };
        }
    }
}