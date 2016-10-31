using System.Collections.Generic;
using System.Linq;

using SQLite.Net;
using System.Threading.Tasks;
using YWW.core.Interfaces;
using YWW.core.Models;
using MvvmCross.Platform;

namespace YWW.core.Database
{
    public class GoalDatabase : IGoalDatabase
    {
        private SQLiteConnection database;

        public GoalDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Goals>();
        }

        public async Task<IEnumerable<Goals>> GetGoals()
        {
            return database.Table<Goals>().ToList();
        }

        public async Task<int> InsertGoals(Goals goal)
        {
            var num = database.Insert(goal);
            database.Commit();
            return num;
        }

        public async Task<int> UpdateGoals(Goals goal)
        {
            database.DropTable<Goals>();
            database.CreateTable<Goals>();
            var num = database.Insert(goal);
            database.Commit();
            return num;
        }
    }
}
