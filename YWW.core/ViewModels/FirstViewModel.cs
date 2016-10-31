using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using YWW.core.Interfaces;

namespace YWW.core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private readonly IGoalDatabase goalDatabase;
        public delegate void MyEventAction(string msg);
        public event MyEventAction Event;

        private int Counter;
        private int _goalTotalCounter;
        public int GoalTotalCounter
        {
            get
            {
                if (Counter != 5)
                {
                    _goalTotalCounter = 0;
                    return _goalTotalCounter;
                }
                if (Counter == 5)
                {
                    _goalTotalCounter = 1;
                    return _goalTotalCounter;
                }
                else
                {
                    _goalTotalCounter = 0;
                    return _goalTotalCounter;
                }
            }
            set
            {
                SetProperty(ref _goalTotalCounter, value);
                RaisePropertyChanged(() => GoalTotalCounter);
            }
        }

        private string selectNewGoal = "You currently have no goals. Please select one.";

        //public void Init(int goalTotalCounter)
        //{
        //    //this.Counter = GoalCounter;
        //    if (goalTotalCounter != 0)
        //    {
        //        this._goalTotalCounter = goalTotalCounter;
        //    }
        //}
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

        public FirstViewModel(IGoalDatabase goalDatabase)
        {
            this.goalDatabase = goalDatabase;
            GetGoalCounter();
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
                ShowViewModel<OverviewProgressViewModel>(new { GoalTotalCounter });
            });

        }
        public async void GetGoalCounter()
        {
            var goals = await goalDatabase.GetGoals();
            foreach (var goal in goals)
            {
                Counter = goal.GoalCounter;
            }
        }

    }
}
