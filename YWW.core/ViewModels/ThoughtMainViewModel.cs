using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;
/**
* Author Jia Xin Chan 9601902
* 
**/
namespace YWW.core.ViewModels
{
    public class ThoughtMainViewModel : MvxViewModel
    {
        private readonly IThoughtDatabase thoughtDatabase;
        private ObservableCollection<ThoughtWrapper> thoughts = new ObservableCollection<ThoughtWrapper>();

        public ThoughtMainViewModel(IThoughtDatabase thoughtDatabase)
        {
            this.thoughtDatabase = thoughtDatabase;
            GetThoughts();
           
        }
        public ObservableCollection<ThoughtWrapper> Thoughts
        {
            get { return thoughts; }
            set { SetProperty(ref thoughts, value); }
        }

        public async void GetThoughts()
        {
            Thoughts.Clear();
            var thoughts = await thoughtDatabase.GetThoughts();
            foreach (var thought in thoughts)
            {
                Thoughts.Add(new ThoughtWrapper(thought));
            }
        }


    }
}
