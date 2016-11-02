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
/**
* Author Lisa-Marie Assmann 9533818
* 
**/
namespace healthJourney.droid.Views
{

    [MvxViewFor(typeof(HealthPlanViewModel))]
    [Activity(Label = "Health Plan")]
    public class healthPlanConfig : MvxActivity
    {
        public HealthPlanViewModel hpvm
        {
            get { return base.ViewModel as HealthPlanViewModel; }
        }
        private void hpvm_Event(string msg)
        {
            var messageToast = Toast.MakeText(this, msg, ToastLength.Long);
            messageToast.Show();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.healthPlanConfig);
            hpvm.Event += hpvm_Event;

            Button commBtn = FindViewById<Button>(Resource.Id.community);
            commBtn.Click += delegate {
                StartActivity(typeof(comm_Main));
            };

            Button exercisebtn = FindViewById<Button>(Resource.Id.exerciseBtn);
            LinearLayout exerciseDetails = FindViewById<LinearLayout>(Resource.Id.exercise_section);
            Button dietbtn = FindViewById<Button>(Resource.Id.dietBtn);
            LinearLayout dietDetails = FindViewById<LinearLayout>(Resource.Id.diet_section);
            Button sleepbtn = FindViewById<Button>(Resource.Id.sleepBtn);
            LinearLayout sleepDetails = FindViewById<LinearLayout>(Resource.Id.sleep_section);
            Button lifestylebtn = FindViewById<Button>(Resource.Id.lifestyleBtn);
            LinearLayout lifestyleDetails = FindViewById<LinearLayout>(Resource.Id.lifestyle);
            //Dropdown of exercise button
            exercisebtn.Click += delegate
            {
                if (exerciseDetails.Visibility == ViewStates.Gone)
                {
                    exerciseDetails.Visibility = ViewStates.Visible;
                    lifestyleDetails.Visibility = ViewStates.Gone;
                    dietDetails.Visibility = ViewStates.Gone;
                    sleepDetails.Visibility = ViewStates.Gone;
                }
                else
                {
                    exerciseDetails.Visibility = ViewStates.Gone;
                };
            };
            //Dropdown of diet button
            dietbtn.Click += delegate
            {
                if (dietDetails.Visibility == ViewStates.Gone)
                {
                    dietDetails.Visibility = ViewStates.Visible;
                    exerciseDetails.Visibility = ViewStates.Gone;
                    lifestyleDetails.Visibility = ViewStates.Gone;
                    sleepDetails.Visibility = ViewStates.Gone;
                }
                else
                {
                    dietDetails.Visibility = ViewStates.Gone;
                };
            };
            //Dropdown of sleep button
            sleepbtn.Click += delegate
            {
                if (sleepDetails.Visibility == ViewStates.Gone)
                {
                    sleepDetails.Visibility = ViewStates.Visible;
                    exerciseDetails.Visibility = ViewStates.Gone;
                    dietDetails.Visibility = ViewStates.Gone;
                    lifestyleDetails.Visibility = ViewStates.Gone;
                }
                else
                {
                    sleepDetails.Visibility = ViewStates.Gone;
                };
            };
            //Dropdown of lifestyle button
            lifestylebtn.Click += delegate
            {
                if (lifestyleDetails.Visibility == ViewStates.Gone)
                {
                    lifestyleDetails.Visibility = ViewStates.Visible;
                    exerciseDetails.Visibility = ViewStates.Gone;
                    dietDetails.Visibility = ViewStates.Gone;
                    sleepDetails.Visibility = ViewStates.Gone;
                }
                else
                {
                    lifestyleDetails.Visibility = ViewStates.Gone;
                };
            };
        }

    }
}