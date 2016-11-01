using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
//Author: Sean Little | n9106201
namespace YWW.core.ViewModels
{
    public class OverviewProgressViewModel
        : MvxViewModel
    {
        //Initialise strings and integers used throughout later methods
        private string _goalTotal;
        private int goalTotalCounter;
        private string _goalCountText;

        //initialise button to navigate to Firstview
        public ICommand weeklyGoals { get; private set; }

        //Initialise constructor with weeklyGoals button
        public OverviewProgressViewModel()
        {
            weeklyGoals = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
        }

        //Assign GoalTotalCounter variable to local goalTotalCounter variable to determine number of goals completed
        public void Init(int GoalTotalCounter)
        {
            this.goalTotalCounter = GoalTotalCounter;
        }

        //Apply logic to goalTotalCounter to determine which image to display according to how many goals the user has completed
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


        //initialise strings to be used in later methods
        private string _goalInitialStatement = "You have completed ";
        private string _goalFinalStatement = " goal/s!";
        private string _goalStatement;

        //Based on number of Goals completed, display them in a string below the column
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
