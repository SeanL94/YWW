
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;
/**
* Author Jia Xin Chan 9601902
* 
**/
namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(PostTopicViewModel))]
    [Activity(Label = "comm_Advice_Main")]
    public class comm_Advice_Main : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_advice_main);

            Button newPostbtn = FindViewById<Button>(Resource.Id.newPostBtn);
            newPostbtn.Click += delegate {
                StartActivity(typeof(comm_Advice_New));
            };

            Button bkBtn = FindViewById<Button>(Resource.Id.backBtn);
            bkBtn.Click += delegate {
                StartActivity(typeof(comm_Main));
            };

        }
    }
}