using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
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
        public ICommand SearchBtn { get; private set; }

        public PostTopicViewModel(IPostDatabase postDatabase)
        {
            this.postDatabase = postDatabase;
            GetPosts();
            SelectTopicCommand = new MvxCommand<Post>(selectedPost =>
            {
                SelectPost(selectedPost);
            });
            SearchBtn = new MvxCommand(SearchPosts);
        }

        public async void SelectPost(Post selectedPost)
        {
            ShowViewModel<PostContentViewModel>(selectedPost );
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

        public async void SearchPosts()
        {
            if (SearchTerm != "" )
            {
                Posts.Clear();
                var posts = await postDatabase.GetPosts();
                foreach (var post in posts)
                {
                    if (Regex.IsMatch(post.SubjectTitle, "(" + SearchTerm + ")+"))
                    {
                        Posts.Add(new PostWrapper(post));
                    }
                }
            }
            else
            {
                GetPosts();
            }
            
        }

        private string _searchTerm;
        public string SearchTerm
        {
            get { return this._searchTerm; }
            set { this.RaiseAndSetIfChanged(ref this._searchTerm, value); }
        }

        private string _subjectTitle;
        public string SubjectTitle
        {
            get { return this._subjectTitle; }
            set { this.RaiseAndSetIfChanged(ref this._subjectTitle, value); }
        }


        
    }
}
