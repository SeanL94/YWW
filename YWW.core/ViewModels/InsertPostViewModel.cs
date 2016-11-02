using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;
/**
* Author Jia Xin Chan 9601902
* 
**/
namespace YWW.core.ViewModels
{
    public class InsertPostViewModel : MvxViewModel
    {
        
        private readonly IPostDatabase postDatabase;
        public ICommand postButton { get; private set; }
        public InsertPostViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
            postButton = new MvxCommand(InsertPost);
        }
        private string _content;
        public string Content
        {
            get { return this._content; }
            set { this.RaiseAndSetIfChanged(ref this._content, value); }
        }

        private string _subject;
        public string SubjectLine
        {
            get { return this._subject; }
            set { this.RaiseAndSetIfChanged(ref this._subject, value); }
        }

        // to check the post privacy
        private bool? _isToggleChecked;
        public bool? IsToggleChecked
        {
            get { return _isToggleChecked; }
            set
            {
                if (_isToggleChecked == value)
                    return;
                _isToggleChecked = value;
                RaisePropertyChanged(() => IsToggleChecked);
            }
        }

        // Method to set privacy depends on the previous isToggled function
        public string getPrivacy()
        {
            if(IsToggleChecked == null)
            {
                return "private";
            }

            return "public";
        }
        public async void InsertPost()
        {
            DateTime now = DateTime.Now.ToLocalTime();
            string privacy = getPrivacy();
            var newPost = (new Post { AuthorID = "1",
                Type = "admin",
                Categories = "Advices",
                Privacy = privacy,
                Contents = this.Content,
                PostDateTime = now,
                SubjectTitle = this.SubjectLine
            });
            await postDatabase.InsertPost(newPost);
        }

        
    }
}
