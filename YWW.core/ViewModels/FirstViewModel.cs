using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace YWW.core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        public delegate void MyEventAction(string msg);
        public event MyEventAction Event;

        private int Counter;
        private int _goalTotalCounter;

        private string selectNewGoal = "You currently have no goals. Please select one.";

        public void Init(int GoalCounter, int goalTotalCounter)
        {
            this.Counter = GoalCounter;
            if (goalTotalCounter != 0)
            {
                this._goalTotalCounter = goalTotalCounter;
            }
        }
        //private int Counter = 1;
        private string _dietProgress;

        public string dietProgress
        {
            get
            {
                if (Counter == 0)
                {
                    _dietProgress = "@drawable/flowers0";
                    return _dietProgress;
                }
                else if (Counter == 1)
                {
                    _dietProgress = "@drawable/flowers25";
                    return _dietProgress;
                }
                else if (Counter == 2)
                {
                    _dietProgress = "@drawable/flowers50";
                    return _dietProgress;
                }
                else if (Counter == 3)
                {
                    _dietProgress = "@drawable/flowers75";
                    return _dietProgress;
                }
                else if (Counter == 4)
                {
                    _dietProgress = "@drawable/flowers100";
                    return _dietProgress;
                }
                else if (Counter == 5)
                {
                    _dietProgress = "@drawable/flowers0";
                    return _dietProgress;
                }
                else
                {
                    _dietProgress = "@drawable/flowers0";
                    return _dietProgress;
                }
            }
            set
            {
                SetProperty(ref _dietProgress, value);
                RaisePropertyChanged(() => dietProgress);
            }
        }

        public ICommand EnterProgress { get; private set; }

        public ICommand GoalOverview { get; private set; }

        public FirstViewModel()
        {
            EnterProgress = new MvxCommand(() =>
            {
                if (Counter != 5)
                {
                    ShowViewModel<ProgressEntryViewModel>(new { Counter });
                }
                if (Counter == 5)
                {
                    Event(selectNewGoal);
                }
            });

            GoalOverview = new MvxCommand(() =>
            {
                ShowViewModel<OverviewProgressViewModel>(new { _goalTotalCounter });
            });

        }
        
    }
}
