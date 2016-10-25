using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class PostViewModel : MvxViewModel
    {
        
        private readonly IPostDatabase postDatabase;
        public ICommand postButton { get; private set; }
        public PostViewModel(IPostDatabase postDatabase)
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
            //await postDatabase.InsertPost(newPost);
        }

        public async void GetPosts()
        {
            //var samplePost = new Post();
            //await postDatabase.InsertPost(samplePost);
            var posts = await postDatabase.GetPosts();
            foreach (var post in posts)
            {
                
            }
        }
    }
}
