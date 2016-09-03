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
    [Activity(Label = "comm_Advice_New")]
    public class comm_Advice_New : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_advice_new);

            Button cancelButton = FindViewById<Button>(Resource.Id.cancelBtn);
            cancelButton.Click += delegate {
                StartActivity(typeof(comm_Advice_Main));
            };

            Button postBtn = FindViewById<Button>(Resource.Id.postBtn);
            postBtn.Click += delegate {
                StartActivity(typeof(comm_Advice_Main));
            };
        }
    }
}