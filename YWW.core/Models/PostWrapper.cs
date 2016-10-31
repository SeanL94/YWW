using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWW.core.Models
{
    public class PostWrapper : Post
    {
        public PostWrapper(Post post)
        {
            SubjectTitle = post.SubjectTitle;
            Contents = post.Contents;
        }
            
}
}
