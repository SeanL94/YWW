
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;

namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(ProfileEditViewModel))]
    [Activity(Label = "View for ProfileEditViewModel")]
    public class profile_edit : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.profile_edit);
        }

    }
}
