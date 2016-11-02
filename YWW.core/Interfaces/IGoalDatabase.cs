using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWW.core.Models;
//Author: Sean Little | n9106201
namespace YWW.core.Interfaces
{
    public interface IGoalDatabase
    {
        Task<IEnumerable<Goals>> GetGoals();
        Task<int> InsertGoals(Goals goal);
        Task<int> UpdateGoals(Goals goal);
        Task<int> SetStatus(int status);
    }
}
