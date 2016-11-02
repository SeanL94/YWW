using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
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
        public ICommand SearchBtn { get; private set; }
        public ThoughtMainViewModel(IThoughtDatabase thoughtDatabase)
        {
            this.thoughtDatabase = thoughtDatabase;
            GetThoughts();
            SearchBtn = new MvxCommand(SearchThoughts);
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

        private string _searchTerm;
        public string SearchTerm
        {
            get { return this._searchTerm; }
            set { this.RaiseAndSetIfChanged(ref this._searchTerm, value); }
        }

        public async void SearchThoughts()
        {
            if (SearchTerm != "")
            {
                Thoughts.Clear();
                var thoughts = await thoughtDatabase.GetThoughts();
                foreach (var thought in thoughts)
                {
                    if (Regex.IsMatch(thought.Contents, "(" + SearchTerm + ")+") || Regex.IsMatch("Johanna Doe", "(" + SearchTerm + ")+")) // regex to match the search term
                    {
                        Thoughts.Add(new ThoughtWrapper(thought));
                    }
                }
            }
            else
            {
                GetThoughts();
            }

        }


    }
}
