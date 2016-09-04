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
 * Author Lisa-Marie Assmann 9533818
 * 
 **/
namespace healthJourney.droid.Views
{
    [Activity(Label = "profile_main")]
    public class profile_main : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.profile_main);

            Button profileEditbtn = FindViewById<Button>(Resource.Id.profileEditBtn);
            profileEditbtn.Click += delegate
            {
                StartActivity(typeof(profile_edit));
            };
            Button healthBtn = FindViewById<Button>(Resource.Id.healthJourney);
            healthBtn.Click += delegate {
                StartActivity(typeof(FirstView));
            };
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
            Button showPlanbtn = FindViewById<Button>(Resource.Id.userPlanBtn);
            TextView userPlan = FindViewById<TextView>(Resource.Id.user_plan);
            showPlanbtn.Click += delegate
            {
                if (userPlan.Visibility == ViewStates.Gone)
                {
                    userPlan.Visibility = ViewStates.Visible;
                }
                else
                {
                    userPlan.Visibility = ViewStates.Gone;
                };
            };
        }
    }
}
