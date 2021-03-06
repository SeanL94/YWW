using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;

//Author: Sean Little | n9106201

namespace healthJourney.droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        //The following is used for a toast method
        public FirstViewModel FVM
        {
            get { return base.ViewModel as FirstViewModel; }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.FirstView);
            FVM.Event += FVM_Event;

            //The following is used to navigate to communication and profile pages
            Button commbutton = FindViewById<Button>(Resource.Id.community);
            commbutton.Click += delegate {
                StartActivity(typeof(comm_Main));
            };
            Button profileBtn = FindViewById<Button>(Resource.Id.profile);
            profileBtn.Click += delegate {
                StartActivity(typeof(profile_main));
            };

        }

        //the following is a method used in a toast function

        private void FVM_Event (string msg)
        {
            var messageToast = Toast.MakeText(this, msg, ToastLength.Long);
            messageToast.Show();
        }
    }
}
