using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

//Author: Sean Little | n9106201

namespace healthJourney.droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.FirstView);

            Button commbutton = FindViewById<Button>(Resource.Id.community);
            commbutton.Click += delegate {
                StartActivity(typeof(comm_Main));
            };
            Button profileBtn = FindViewById<Button>(Resource.Id.profile);
            profileBtn.Click += delegate {
                StartActivity(typeof(profile_main));
            };
            Button overviewbtn = FindViewById<Button>(Resource.Id.toggleButton1);
            overviewbtn.Click += delegate {
                StartActivity(typeof(overview_progress));
            };
            //Button progressEntry = FindViewById<Button>(Resource.Id.progressEntry);
            //progressEntry.Click += delegate {
            //    StartActivity(typeof(progress_entry));
            //};
        }
    }
}
