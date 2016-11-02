using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWW.core.Models;
using static YWW.core.Models.User;
//Author: Lisa-Marie | n9533818

namespace YWW.core.Interfaces
{
    public interface IUserDatabase
    {
        Task<int> CreateUser(User user);
        Task<IEnumerable<User>> GetUser();
        Task<int> UpdateUser(User user);
    }
}
