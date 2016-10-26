using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;

//Author: Sean Little | n9106201

namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(OverviewProgressViewModel))]
    [Activity(Label = "View for OverviewProgressViewModel")]
    public class overview_progress : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.overview_progress);

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
                StartActivity(typeof(FirstView));
            };
        }
    }
}
