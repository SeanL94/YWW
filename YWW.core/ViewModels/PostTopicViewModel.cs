using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class PostTopicViewModel : MvxViewModel
    {
        private readonly IPostDatabase postDatabase;
        private ObservableCollection<PostWrapper> posts = new ObservableCollection<PostWrapper>();

        public PostTopicViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
            GetPosts();
        }
        public ObservableCollection<PostWrapper> Posts
        {
            get { return posts; }
            set { SetProperty(ref posts, value); }
        }

        public async void GetPosts()
        {
            var posts = await postDatabase.GetPosts();
            foreach (var post in posts)
            {
                Posts.Add(new PostWrapper(post));
            }
        }
    }
}
