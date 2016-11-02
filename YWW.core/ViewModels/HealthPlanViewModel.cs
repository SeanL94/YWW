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
        private int _setGoal;
        public int SetGoal
        {
            get { return _setGoal; }
            set { SetProperty(ref _setGoal, value); }
        }
        public HealthPlanViewModel()
        {

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
                if (SetGoal == 0)
                {
                    SetGoal = 1;
                }
                else
                {
                    SetGoal = 1;
                }
                ShowViewModel<ProgressEntryViewModel>(SetGoal);
            });
            Ex2Select = new MvxCommand(() =>
            {
                if (SetGoal == 0)
                {
                    SetGoal = 2;
                }
                else
                {
                    SetGoal = 2;
                }
                ShowViewModel<ProgressEntryViewModel>(SetGoal);
            });
            Ex3Select = new MvxCommand(() =>
            {
                if (SetGoal == 0)
                {
                    SetGoal = 3;
                }
                else
                {
                    SetGoal = 3;
                }
                ShowViewModel<ProgressEntryViewModel>(SetGoal);
            });
            Ex4Select = new MvxCommand(() =>
            {
                if (SetGoal == 0)
                {
                    SetGoal = 4;
                }
                else
                {
                    SetGoal = 4;
                }
                ShowViewModel<ProgressEntryViewModel>(SetGoal);
            });
        }
    }
}
