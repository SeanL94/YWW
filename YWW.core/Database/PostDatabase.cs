using System.Collections.Generic;
using System.Linq;

using SQLite.Net;
using System.Threading.Tasks;
using YWW.core.Interfaces;
using YWW.core.Models;
using MvvmCross.Platform;

namespace YWW.core.Database
{
    public class PostDatabase : IPostDatabase
    {
        private SQLiteConnection database;

        public PostDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Post>();
        }
        public async Task<IEnumerable<Post>> GetPosts()
        {
            return database.Table<Post>().ToList();
        }

        public async Task<int> InsertPost(Post post)
        {
            var num = database.Insert(post);
            database.Commit();
            return num;
        }
    }

}
