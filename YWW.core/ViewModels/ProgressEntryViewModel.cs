using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YWW.core.ViewModels
{
    public class ProgressEntryViewModel
        : MvxViewModel
    {
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
                //goalProgress = _goalentry;
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
                    //RaisePropertyChanged(() => goalProgress);
                }
            }
        }

        //---------------------------------------------------------------------------------------

        public ICommand ButtonCommand { get; private set; }

        public ProgressEntryViewModel()
        {
            ButtonCommand = new MvxCommand(() =>
            {
                RaisePropertyChanged(() => goalProgress);
            });
        }
    }
}
