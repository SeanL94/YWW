using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWW.core.ViewModels;

namespace YWW.core.Models
{
    public class PostWrapper : Post
    {
        public PostWrapper(Post post)
        {
            SubjectTitle = post.SubjectTitle;
            Contents = post.Contents; 
        }

        Post _post;
        PostTopicViewModel _parent;

        public PostWrapper(Post post, PostTopicViewModel parent)
        {
            _post = post;
            _parent = parent;
        }
        public IMvxCommand SelectTopicCommand
        {
            get
            {
                return new MvxCommand(() => _parent.SelectPost(_post));
            }
        }

        public Post Post { get { return _post; } }

    }
}
