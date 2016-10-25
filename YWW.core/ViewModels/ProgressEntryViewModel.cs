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
                dietIntake = int.Parse(goalProgress);

                if (dietIntake < 9000)
                {
                    GoalCounter = GoalCounter + 1;
                }
                if (GoalCounter == 5)
                {
                    SuccessEvent(Success);
                }
                ShowViewModel<FirstViewModel>(new { GoalCounter });
            });
        }
    }
}
