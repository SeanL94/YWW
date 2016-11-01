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
using Android.Util;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;

namespace healthJourney.droid.Views
{

    [MvxViewFor(typeof(HealthPlanViewModel))]
    [Activity(Label = "Health Plan")]
    public class healthPlanConfig : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.health_plan_config);

            Button commBtn = FindViewById<Button>(Resource.Id.community);
            commBtn.Click += delegate {
                StartActivity(typeof(comm_Main));
            };

            Button exercisebtn = FindViewById<Button>(Resource.Id.exerciseBtn);
            LinearLayout exerciseDetails = FindViewById<LinearLayout>(Resource.Id.exercise_section);
            exercisebtn.Click += delegate
            {
                if (exerciseDetails.Visibility == ViewStates.Gone)
                {
                    exerciseDetails.Visibility = ViewStates.Visible;
                }
                else
                {
                    exerciseDetails.Visibility = ViewStates.Gone;
                };
            };
            Button dietbtn = FindViewById<Button>(Resource.Id.dietBtn);
            LinearLayout dietDetails = FindViewById<LinearLayout>(Resource.Id.diet_section);
            dietbtn.Click += delegate
            {
                if (dietDetails.Visibility == ViewStates.Gone)
                {
                    dietDetails.Visibility = ViewStates.Visible;
                }
                else
                {
                    dietDetails.Visibility = ViewStates.Gone;
                };
            };
            Button sleepbtn = FindViewById<Button>(Resource.Id.sleepBtn);
            LinearLayout sleepDetails = FindViewById<LinearLayout>(Resource.Id.sleep_section);
            sleepbtn.Click += delegate
            {
                if (sleepDetails.Visibility == ViewStates.Gone)
                {
                    sleepDetails.Visibility = ViewStates.Visible;
                }
                else
                {
                    sleepDetails.Visibility = ViewStates.Gone;
                };
            };
            Button lifestylebtn = FindViewById<Button>(Resource.Id.lifestyleBtn);
            LinearLayout lifestyleDetails = FindViewById<LinearLayout>(Resource.Id.lifestyle);
            lifestylebtn.Click += delegate
            {
                if (lifestyleDetails.Visibility == ViewStates.Gone)
                {
                    lifestyleDetails.Visibility = ViewStates.Visible;
                }
                else
                {
                    lifestyleDetails.Visibility = ViewStates.Gone;
                };
            };
        }

    }
}