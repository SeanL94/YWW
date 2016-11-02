using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWW.core.Models;

namespace YWW.core.Interfaces
{
    public interface IThoughtDatabase
    {
        Task<IEnumerable<Thought>> GetThoughts();
        Task<int> InsertThought(Thought thought);
    }
}
