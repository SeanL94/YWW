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
            PostDateTime = post.PostDateTime;
        }

    }
}
