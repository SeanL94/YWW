using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWW.core.Database;
using YWW.core.Interfaces;
using YWW.core.Models;
using static Android.Provider.Settings;
//Author: Sean Little | n9106201
namespace YWW.core.ViewModels
{
    public class ProgressEntryViewModel
        : MvxViewModel
    {
        //Initialise database and toast event
        private readonly IGoalDatabase goalDatabase;
        public delegate void MyEventAction(string msg);
        public event MyEventAction SuccessEvent;

        //Strings to be used with toast notification event
        private string Success = "Congratulations on completing your goal!";
        private string goalAchieved = "Well Done! You've achieved your goal for the day!";
        private string goalFailed = "Unfortunately you have not met your goal today. Try again tomorrow";
        private string valueMissing = "Please enter in a value";

        //initialise goalTotalCounter which will be updated to record the users progress through a goal
        private int goalTotalCounter;

        //hard coded strings that will eventually be pulled from the db in later versions
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

        //Pulls the users entry in the form and assigns it to a variable
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

        //Initialised the button bindings

        public ICommand ButtonCommand { get; private set; }

        public ICommand CancelButton { get; private set; }

        //initialise integers used in following methods
        int counter = 0;
        private int dietIntake;
        private int GoalCounter = 0;
        
        //Initialise constructor with database connection
        public ProgressEntryViewModel(IGoalDatabase goalDatabase)
        {
           this.goalDatabase = goalDatabase;
            //Call function to pull GoalCounter from database
            getGoalCounter();
            
            //When button command is pressed, check if user's entry is null and respond
            ButtonCommand = new MvxCommand(() =>
            {
                if (goalProgress == null)
                {
                    SuccessEvent(valueMissing);
                }

                //if it is not null, parse their entry to an integer
                else if (goalProgress != null)
                {
                    dietIntake = int.Parse(goalProgress);
                    //check if entry meets goal and respond with success of fail event
                    if (dietIntake < 9000)
                    {
                        //Increase GoalCounter value to record progress
                        GoalCounter = GoalCounter + 1;
                        SuccessEvent(goalAchieved);
                    }
                    //Other responses
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
                        //Notify user that Goal has been completed
                        SuccessEvent(Success);
                        goalTotalCounter = goalTotalCounter + 1;
                    }
                    //Call method to insert new goal value into the database
                    InsertGoal();
                    
                    //navigate to firstfiewmodel.cs
                    ShowViewModel<FirstViewModel>();
                }

            });
            //Navigate back to FirstViewModel without altering anything
            CancelButton = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
        }

        //Method to insert GoalCounter into table
        //It assigns local GoalCounter variable to goals.GoalCounter in DB
        //Then, if the database hasn't yet been created it inserts the entry
        //Otherwise, it Updates
        public async void InsertGoal()
        {
           var newGoal = (new Goals
            {
                GoalCounter = GoalCounter,
            });
            if(counter == 0)
                await goalDatabase.InsertGoals(newGoal);
            else
                await goalDatabase.UpdateGoals(newGoal);
        }

        //Method to Get GoalCounter value
        public async void getGoalCounter()
        {
            var goals = await goalDatabase.GetGoals();
            foreach (var goal in goals)
            {
                counter++;
                GoalCounter = goal.GoalCounter;
            }
        }

    }
}
