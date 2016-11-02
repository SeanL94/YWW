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
    public class PostContentViewModel : MvxViewModel
    {
        private readonly IPostDatabase postDatabase;
        
        public PostContentViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
        }
        public void Init(Post selectedPost)
        {
            // post from the selected post from PostTopicViewModel
            Contents = selectedPost.Contents;
            PostDateTime = selectedPost.PostDateTime.ToString();
            SubjectTitle = selectedPost.SubjectTitle;
        }

        private string _contents;
        public string Contents
        {
            get { return this._contents; }
            set { this.RaiseAndSetIfChanged(ref this._contents, value); }
        }
        private string _subjectTitle;
        public string SubjectTitle
        {
            get { return this._subjectTitle; }
            set { this.RaiseAndSetIfChanged(ref this._subjectTitle, value); }
        }
        private string _datetime;
        public string PostDateTime
        {
            get { return this._datetime; }
            set { this.RaiseAndSetIfChanged(ref this._datetime, value); }
        }
    }
}
