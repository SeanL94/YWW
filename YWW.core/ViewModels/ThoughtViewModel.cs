using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class ThoughtViewModel : MvxViewModel
    {
        private readonly IPostDatabase postDatabase;
        public ICommand thoughtButton { get; private set; }
        public ThoughtViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
            thoughtButton = new MvxCommand(InsertThought);
        }

        private string _imageURL;
        public string ImageUrl
        {
            get { return _imageURL; }
            set
            {
                _imageURL = value;
                RaisePropertyChanged(() => ImageUrl);
            }
        }

        public object Bytes { get; set; }

        public async void InsertThought()
        {
            DateTime now = DateTime.Now.ToLocalTime();
            string temp = this.ImageUrl;
            //await postDatabase.InsertThought(thought);
        }
    }
}
