using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YWW.core.ViewModels
{
    public class OverviewProgressViewModel
        : MvxViewModel
    {
        private string _goalTotal;
        private int goalTotalCounter;
        private string _goalCountText;

        public ICommand weeklyGoals { get; private set; }

        public OverviewProgressViewModel()
        {
            weeklyGoals = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
        }

        public void Init(int GoalTotalCounter)
        {
            this.goalTotalCounter = GoalTotalCounter;
        }

        public string GoalTotal
        {
            get
            {
                if (goalTotalCounter == 0)
                {
                    _goalTotal = "@drawable/flowers0";
                    return _goalTotal;
                }
                if (goalTotalCounter == 1)
                {
                    _goalTotal = "@drawable/flowers25";
                    return _goalTotal;
                }
                else
                {
                    _goalTotal = "@drawable/flowers0";
                    return _goalTotal;
                }
            }
            set
            {
                SetProperty(ref _goalTotal, value);
                RaisePropertyChanged(() => GoalTotal);
            }
        }

        private string _goalInitialStatement = "You have completed ";
        private string _goalFinalStatement = " goal/s!";
        private string _goalStatement;
        public string GoalStatement
        {
            get
            {
                _goalCountText = goalTotalCounter.ToString();
                _goalStatement = _goalInitialStatement + _goalCountText + _goalFinalStatement;
                return _goalStatement;
            }
            set
            {
                SetProperty(ref _goalStatement, value);
                RaisePropertyChanged(() => GoalStatement);
            }
        }

    }
}
