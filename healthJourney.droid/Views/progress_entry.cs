using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using YWW.core.ViewModels;
using static healthJourney.droid.Resource;

//Author: Sean Little | n9106201

namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(ProgressEntryViewModel))]
    [Activity(Label = "View for ProgressEntryViewModel")]
    public class progress_entry : MvxActivity
    {
        public ProgressEntryViewModel pevm
        {
            get { return base.ViewModel as ProgressEntryViewModel; }
        }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Layout.progress_entry);
            pevm.SuccessEvent += pevm_Success_Event;

            //Button enterButton = FindViewById<Button>(Id.enterButton);
            //enterButton.Click += delegate
            //{
            //    StartActivity(typeof(FirstView));
            //};
            Button cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            cancelButton.Click += delegate
            {
                StartActivity(typeof(FirstView));
            };
        }

        private void pevm_Success_Event(string msg)
        {
            var SuccessToast = Toast.MakeText(this, msg, ToastLength.Long);
            SuccessToast.Show();
        }

    }
}
