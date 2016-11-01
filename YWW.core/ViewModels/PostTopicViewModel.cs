using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class PostTopicViewModel : MvxViewModel
    {
        private readonly IPostDatabase postDatabase;
        public ObservableCollection<PostWrapper> posts = new ObservableCollection<PostWrapper>();
        public ICommand SelectTopicCommand { get; private set; }

        public PostTopicViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
            GetPosts();
            SelectTopicCommand = new MvxCommand<PostWrapper>(selectedPost =>
            {
                SelectPost(selectedPost);
            });
        }

        public async void SelectPost(PostWrapper selectedPost)
        {
            Post temp = selectedPost;
        }
        public ObservableCollection<PostWrapper> Posts
        {
            get { return posts; }
            set { SetProperty(ref posts, value); }
        }

        public async void GetPosts()
        {
            Posts.Clear();
            var posts = await postDatabase.GetPosts();
            foreach (var post in posts)
            {
                Posts.Add(new PostWrapper(post));
            }
        }

        private string _subjectTitle;
        public string SubjectTitle
        {
            get { return this._subjectTitle; }
            set { this.RaiseAndSetIfChanged(ref this._subjectTitle, value); }
        }

        public async void GetClick()
        {
            string temp = SubjectTitle;
        }

        
    }
}
