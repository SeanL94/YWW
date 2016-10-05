using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using static healthJourney.droid.Resource;

//Author: Sean Little | n9106201

namespace healthJourney.droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class progress_entry : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Layout.progress_entry);

            //ListView GoalLV = FindViewById<ListView>(Id.GoalList);

            Button enterButton = FindViewById<Button>(Id.enterButton);
            enterButton.Click += delegate {
                StartActivity(typeof(FirstView));
            };
            Button cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            cancelButton.Click += delegate {
                StartActivity(typeof(FirstView));
            };
        }
        public string GoalQuestion = "How many kms have you run?";



    }
}
