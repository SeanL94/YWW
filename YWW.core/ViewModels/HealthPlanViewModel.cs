using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class HealthPlanViewModel : MvxViewModel
    {
        public ICommand GoToMain { get; private set; }
        public ICommand GoToProfile { get; private set; }
        public ICommand Ex1Select { get; private set; }
        public ICommand Ex2Select { get; private set; }
        public ICommand Ex3Select { get; private set; }
        public ICommand Ex4Select { get; private set; }
        public ICommand Diet1Select { get; private set; }
        public ICommand Diet2Select { get; private set; }
        public ICommand Diet3Select { get; private set; }
        public ICommand Diet4Select { get; private set; }
        public ICommand Sleep1Select { get; private set; }
        public ICommand Sleep2Select { get; private set; }
        public ICommand Sleep3Select { get; private set; }
        public ICommand Sleep4Select { get; private set; }
        public ICommand Life1Select { get; private set; }
        public ICommand Life2Select { get; private set; }
        public ICommand Life3Select { get; private set; }
        public ICommand Life4Select { get; private set; }



        public delegate void MyEventAction(string msg);
        public event MyEventAction Event;
        private string selectEx1 = "You selected exercise 1.";
        private string selectEx2 = "You selected exercise 2.";
        private string selectEx3 = "You selected exercise 3.";
        private string selectEx4 = "You selected exercise 4.";
        private string selectDiet1 = "You selected diet plan 1.";
        private string selectDiet2 = "You selected diet plan 2.";
        private string selectDiet3 = "You selected diet plan 3.";
        private string selectDiet4 = "You selected diet plan 4.";
        private string selectSleep1 = "You selected sleep advice 1.";
        private string selectSleep2 = "You selected sleep advice 2.";
        private string selectSleep3 = "You selected sleep advice 3.";
        private string selectSleep4 = "You selected sleep advice 4.";
        private string selectLife1 = "You selected lifestyle advice 1.";
        private string selectLife2 = "You selected lifestyle advice 2.";
        private string selectLife3 = "You selected lifestyle advice 3.";
        private string selectLife4 = "You selected lifestyle advice 4.";

        private IGoalDatabase goalDatabase;
        public HealthPlanViewModel(IGoalDatabase goalDatabase)
        {
            this.goalDatabase = goalDatabase;
            GetStat();
            GoToMain = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
            GoToProfile = new MvxCommand(() =>
            {
                ShowViewModel<ProfileMainViewModel>();
            });
            Ex1Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectEx1);
                }
                else
                {
                    //SetStat(1);
                    Event(selectEx1);
                }
            });
            Ex2Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(2);
                    Event(selectEx2);
                }
                else
                {
                    //SetStat(2);
                    Event(selectEx2);
                }
            });
            Ex3Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(3);
                    Event(selectEx3);
                }
                else
                {
                    //SetStat(3);
                    Event(selectEx3);
                }
            });
            Ex4Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(4);
                    Event(selectEx4);
                }
                else
                {
                    //SetStat(4);
                    Event(selectEx4);
                }
            });
            Diet1Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectDiet1);
                }
                else
                {
                    //SetStat(1);
                    Event(selectDiet1);
                }
            });
            Diet2Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectDiet2);
                }
                else
                {
                    //SetStat(1);
                    Event(selectDiet2);
                }
            });
            Diet3Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectDiet3);
                }
                else
                {
                    //SetStat(1);
                    Event(selectDiet3);
                }
            });
            Diet4Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectDiet4);
                }
                else
                {
                    //SetStat(1);
                    Event(selectDiet4);
                }
            });
            Sleep1Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectSleep1);
                }
                else
                {
                    //SetStat(1);
                    Event(selectSleep1);
                }
            });
            Sleep2Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectSleep2);
                }
                else
                {
                    //SetStat(1);
                    Event(selectSleep2);
                }
            });
            Sleep3Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectSleep3);
                }
                else
                {
                    //SetStat(1);
                    Event(selectSleep3);
                }
            });
            Sleep4Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectSleep4);
                }
                else
                {
                    //SetStat(1);
                    Event(selectSleep4);
                }
            });
            Life1Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectLife1);
                }
                else
                {
                    //SetStat(1);
                    Event(selectLife1);
                }
            });
            Life2Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectLife2);
                }
                else
                {
                    //SetStat(1);
                    Event(selectLife2);
                }
            });
            Life3Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectLife3);
                }
                else
                {
                    //SetStat(1);
                    Event(selectLife3);
                }
            });
            Life4Select = new MvxCommand(() =>
            {
                if (GoalStatus == 0)
                {
                    //SetStat(1);
                    Event(selectLife4);
                }
                else
                {
                    //SetStat(1);
                    Event(selectLife4);
                }
            });
        }
        private int _goalStatus;
        public int GoalStatus
        {
            get { return _goalStatus; }
            set { SetProperty(ref _goalStatus, value); }
        }
        public async void GetStat()
        {
            var goal = await goalDatabase.GetGoals();
            foreach (var g in goal)
            {
                GoalStatus = g.GoalStatus;
            }
        }
        public async void SetStat(int stat)
        {
            await goalDatabase.SetStatus(stat);
        }
    }
}
