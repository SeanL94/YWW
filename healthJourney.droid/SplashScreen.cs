using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace healthJourney.droid
{
    //author: Sean Little | n9106201
    [Activity(
        Label = "Younger Women's Wellness"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
