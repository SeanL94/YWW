using Android.Graphics;
using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class ThoughtViewModel : MvxViewModel
    {
        private readonly IThoughtDatabase thoughtDatabase;

        public ICommand thoughtButton { get; private set; }
        public ThoughtViewModel(IThoughtDatabase thoughtDatabase)
        {
            this.thoughtDatabase = thoughtDatabase;
            thoughtButton = new MvxCommand(InsertThought);
        }

        private string image;
        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                RaisePropertyChanged(() => Image);
            }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChanged(() => Content);
            }
        }


        public async void InsertThought()
        {
            DateTime now = DateTime.Now.ToLocalTime();
            string temp = this.Image;
           var newThought = (new Thought
            {
                AuthorID = "1",
               ThoughtDateTime = now,
               Contents = this.Content
           });
            await thoughtDatabase.InsertThought(newThought);
        }
    }
}
