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
using MvvmCross.Core.ViewModels;
using YWW.core.ViewModels;
using MvvmCross.Droid.Views;
/**
* Author Lisa-Marie Assmann 9533818
* 
**/
namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(ProfileMainViewModel))]
    [Activity(Label = "View for ProfileMainViewModel")]
    public class profile_main : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.profile_main);

            Button commBtn = FindViewById<Button>(Resource.Id.community);
            commBtn.Click += delegate {
                StartActivity(typeof(comm_Main));
            };
            Button showDetailbtn = FindViewById<Button>(Resource.Id.userDetailsBtn);
            TextView userDetails = FindViewById<TextView>(Resource.Id.user_details);
            showDetailbtn.Click += delegate
            {
                if (userDetails.Visibility == ViewStates.Gone)
                {
                    userDetails.Visibility = ViewStates.Visible;
                }
                else
                {
                    userDetails.Visibility = ViewStates.Gone;
                };
            };
            Button showHistorybtn = FindViewById<Button>(Resource.Id.userHistoryBtn);
            TextView userHistory = FindViewById<TextView>(Resource.Id.user_history);
            showHistorybtn.Click += delegate
            {
                if (userHistory.Visibility == ViewStates.Gone)
                {
                    userHistory.Visibility = ViewStates.Visible;
                }
                else
                {
                    userHistory.Visibility = ViewStates.Gone;
                };
            };
            Button showGroupsbtn = FindViewById<Button>(Resource.Id.userGroupsBtn);
            TextView userSocial = FindViewById<TextView>(Resource.Id.user_social);
            showGroupsbtn.Click += delegate
            {
                if (userSocial.Visibility == ViewStates.Gone)
                {
                    userSocial.Visibility = ViewStates.Visible;
                }
                else
                {
                    userSocial.Visibility = ViewStates.Gone;
                };
            };
        }
    }
}
