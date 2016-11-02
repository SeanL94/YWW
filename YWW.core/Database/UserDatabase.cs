using MvvmCross.Platform;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWW.core.Interfaces;
using YWW.core.Models;
using static YWW.core.Models.User;
//Author: Lisa-Marie | n9533818

namespace YWW.core.Database
{
    public class UserDatabase : IUserDatabase
    {
        private SQLiteConnection database;
        public UserDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<User>();
        }

        public async Task<int> CreateUser(User user)
        {
            User tmp = new User(user);
            var num = database.Insert(tmp);
            database.Commit();
            return num;
        }

        public async Task<IEnumerable<User>> GetUser()
        {
            return database.Table<User>().ToList();
        }
        public async Task<int> UpdateUser(User user)
        {
            database.DropTable<User>();
            database.CreateTable<User>();
            var num = database.Insert(user);
            database.Commit();
            return num;
        }
    }
}
