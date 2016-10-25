using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWW.core.Models;

namespace YWW.core.Interfaces
{
    public interface IPostDatabase
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<int> InsertPost(Post post);
    }
}
