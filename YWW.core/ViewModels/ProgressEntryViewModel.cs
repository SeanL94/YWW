using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Android.Provider.Settings;

namespace YWW.core.ViewModels
{
    public class ProgressEntryViewModel
        : MvxViewModel
    {
        public delegate void MyEventAction(string msg);
        public event MyEventAction SuccessEvent;

        private string Success = "Congratulations on completing your goal!";
        private string goalAchieved = "Well Done! You've achieved your goal for the day!";
        private string goalFailed = "Unfortunately you have not met your goal today. Try again tomorrow";
        private string valueMissing = "Please enter in a value";

        private int goalTotalCounter;
        private string _goal = "Keep daily intake under 9'000 kjs";
        private string _goalQuestion = "What was your daily intake today (KJs)?";
        public string Goal
        {
            get { return _goal; }
            set
            {
                if (value != null && value != _goal)
                {
                    _goal = value;
                    RaisePropertyChanged(() => Goal);
                }
            }
        }
        public string goalQuestion
        {
            get { return _goalQuestion; }
            set
            {
                if (value != null && value != _goalQuestion)
                {
                    _goalQuestion = value;
                    RaisePropertyChanged(() => goalQuestion);
                }
            }
        }
        //-----------------------------------------------------------------------------------------

        private string _goalentry;
        public string goalEntry
        {
            get { return _goalentry; }
            set
            {
                SetProperty(ref _goalentry, value);
            }
        }

        public string goalProgress
        {
            get { return _goalentry; }
            set
            {
                if (value != null && value != _goalentry)
                {
                    _goalentry = value;
                }
            }
        }

        //---------------------------------------------------------------------------------------

        public ICommand ButtonCommand { get; private set; }

        public ICommand CancelButton { get; private set; }

        public void Init(int Counter)
        {
            this.goalCounter = Counter;
        }

        private int dietIntake;
        private int goalCounter;
        public int GoalCounter
        {
            get { return goalCounter; }
            set
            {
                goalCounter = value;
            }
        }

        public ProgressEntryViewModel()
        {
            ButtonCommand = new MvxCommand(() =>
            {
                if (goalProgress == null)
                {
                    SuccessEvent(valueMissing);
                }
                else if (goalProgress != null)
                {
                    dietIntake = int.Parse(goalProgress);

                    if (dietIntake < 9000)
                    {
                        GoalCounter = GoalCounter + 1;
                        SuccessEvent(goalAchieved);
                    }
                    if (dietIntake == 0)
                    {
                        SuccessEvent(valueMissing);
                    }
                    if (dietIntake > 9000)
                    {
                        SuccessEvent(goalFailed);
                    }
                    if (GoalCounter == 5)
                    {
                        SuccessEvent(Success);
                        goalTotalCounter = goalTotalCounter + 1;
                    }

                    ShowViewModel<FirstViewModel>(new { GoalCounter, goalTotalCounter });
                }

            });
            CancelButton = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>(new { GoalCounter, goalTotalCounter });
            });
        }
    }
}
