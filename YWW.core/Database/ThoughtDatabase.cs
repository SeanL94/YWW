using System.Collections.Generic;
using System.Linq;

using SQLite.Net;
using System.Threading.Tasks;
using YWW.core.Interfaces;
using YWW.core.Models;
using MvvmCross.Platform;

namespace YWW.core.Database
{
    public class ThoughtDatabase : IThoughtDatabase
    {
        private SQLiteConnection database;

        public ThoughtDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Thought>();
        }
        public async Task<IEnumerable<Thought>> GetThoughts()
        {
            return database.Table<Thought>().ToList();
        }

        public async Task<int> InsertThought(Thought thought)
        {
            var num = database.Insert(thought);
            database.Commit();
            return num;
        }
    }

}
