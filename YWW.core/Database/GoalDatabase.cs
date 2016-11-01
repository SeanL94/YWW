using System.Collections.Generic;
using System.Linq;

using SQLite.Net;
using System.Threading.Tasks;
using YWW.core.Interfaces;
using YWW.core.Models;
using MvvmCross.Platform;
//Author: Sean Little | n9106201
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
        //Function to get goalCounter value
        public async Task<IEnumerable<Goals>> GetGoals()
        {
            return database.Table<Goals>().ToList();
        }

        //function to insert goalCounter value for first time
        public async Task<int> InsertGoals(Goals goal)
        {
            var num = database.Insert(goal);
            database.Commit();
            return num;
        }
        //function to update goalCounter once it has alread been created
        //drops table and recreates new one with current value
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
