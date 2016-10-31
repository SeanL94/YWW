using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using YWW.core.ViewModels;
using MvvmCross.Binding.BindingContext;
/**
* Author Jia Xin Chan 9601902
* 
**/
namespace healthJourney.droid.Views
{
    [MvxViewFor(typeof(ThoughtViewModel))]
    [Activity(Label = "comm_Sharing_New")]
    public class comm_Sharing_New : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.comm_sharing_new);

            Button cancelButton = FindViewById<Button>(Resource.Id.cancelBtn);
            cancelButton.Click += delegate
            {
                StartActivity(typeof(comm_Sharing_Main));
            };

            Button postBtn = FindViewById<Button>(Resource.Id.postBtn);
            postBtn.Click += delegate
            {
                StartActivity(typeof(comm_Sharing_Main));
            };

            ImageView imageIcon = FindViewById<ImageView>(Resource.Id.postImg);
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
                    FindViewById<ImageView>(Resource.Id.postImg);
                imageView.SetImageURI(data.Data);
            }
        }
    }
}