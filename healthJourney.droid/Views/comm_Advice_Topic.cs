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
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;
using MvvmCross.Core.ViewModels;
/**
* Author Jia Xin Chan 9601902
* 
**/
namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(PostContentViewModel))]
    [Activity(Label = "comm_Advice_Topic")]
    public class comm_Advice_Topic : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_advice_topic);

            Button newPostbtn = FindViewById<Button>(Resource.Id.newPostBtn);
            newPostbtn.Click += delegate {
                StartActivity(typeof(comm_Advice_New));
            };

            Button bkBtn = FindViewById<Button>(Resource.Id.bkBtn);
            bkBtn.Click += delegate {
                StartActivity(typeof(comm_Advice_Main));
            };

            
        }
    }
}