using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;

//Author: Sean Little | n9106201

namespace healthJourney.droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class progress_entry : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.progress_entry);

            Button enterButton = FindViewById<Button>(Resource.Id.enterButton);
            enterButton.Click += delegate {
                StartActivity(typeof(FirstView));
            };
            Button cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            cancelButton.Click += delegate {
                StartActivity(typeof(FirstView));
            };
        }
    }
}
