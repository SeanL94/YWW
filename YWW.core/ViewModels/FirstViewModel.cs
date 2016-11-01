using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using YWW.core.Interfaces;
//Author: Sean Little | n9106201
namespace YWW.core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        //initialise toast events and database connection
        private readonly IGoalDatabase goalDatabase;
        public delegate void MyEventAction(string msg);
        public event MyEventAction Event;

        //initialise Counter and GoalTotalCounter variables
        private int Counter;
        private int _goalTotalCounter;

        //Based on value of GoalCounter in DB, assign value to GoalTotalCounter
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


        //Initialise string for toast notification if user needs to select new goal
        private string selectNewGoal = "You currently have no goals. Please select one.";

        //initialise string to represent users progress
        private string _dietProgress;

        //Based on value of GoalCounter in database, display users progress through the goal represented by flowers image
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

        //Initialise buttons for navigating to progress entry, and goaloverview
        public ICommand EnterProgress { get; private set; }

        public ICommand GoalOverview { get; private set; }

        //Initialise constructor with connection to database
        public FirstViewModel(IGoalDatabase goalDatabase)
        {
            //Get GoalCounter value from database
            this.goalDatabase = goalDatabase;
            GetGoalCounter();

            //Navigate to Progress entry page if GoalCounter does not equal 5
            EnterProgress = new MvxCommand(() =>
            {
                if (Counter != 5)
                {
                    ShowViewModel<ProgressEntryViewModel>();
                }
                if (Counter == 5)
                {
                    Event(selectNewGoal);
                }
            });

            //Navigate to GoalOverview page with Goal Total Counter value
            GoalOverview = new MvxCommand(() =>
            {
                ShowViewModel<OverviewProgressViewModel>(new { GoalTotalCounter });
            });
        }

        //initialise method to Get Goal Counter value from database
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
