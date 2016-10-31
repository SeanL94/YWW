
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
    [MvxViewFor(typeof(InsertPostViewModel))]
    [Activity(Label = "comm_Advice_New")]
    public class comm_Advice_New : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_advice_new);

            Button cancelButton = FindViewById<Button>(Resource.Id.cancelBtn);
            cancelButton.Click += delegate {
                StartActivity(typeof(comm_Advice_Main));
            };

            Button postBtn = FindViewById<Button>(Resource.Id.postBtn);
            postBtn.Click += delegate {
                StartActivity(typeof(comm_Advice_Main));
            };
        }

    }
}