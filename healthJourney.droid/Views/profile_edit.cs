
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;
/**
* Author Lisa-Marie Assmann 9533818
* 
**/
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

            ImageView imageIcon = FindViewById<ImageView>(Resource.Id.profileImg);
            imageIcon.Click += delegate
            {
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                    Intent.CreateChooser(imageIntent, "Select photo"), 0);
            };
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {
                var imageView =
                    FindViewById<ImageView>(Resource.Id.profileImg);
                imageView.SetImageURI(data.Data);
            }
        }

    }

}
