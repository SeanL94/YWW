using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWW.core.ViewModels;

namespace YWW.core.Models
{
    public class ThoughtWrapper : Thought
    {
        public ThoughtWrapper(Thought thought)
        {
            
            Contents = thought.Contents;

        }
        
    }
}
