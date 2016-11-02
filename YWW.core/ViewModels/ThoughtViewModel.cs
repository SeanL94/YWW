using Android.Graphics;
using MvvmCross.Core.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;
/**
* Author Jia Xin Chan 9601902
* 
**/
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

        private string myImage;
        public string Image
        {
            get
            {
                return myImage;
            }
            set
            {
                myImage = value;
                RaisePropertyChanged(() => Image);
            }
        }


        public async void InsertThought()
        {
            DateTime now = DateTime.Now.ToLocalTime();
            string temp = Image;
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
