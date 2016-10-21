using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace YWW.core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private int _kjIntake = 8000;
        private int dietPercentage = 0;
        private string _dietProgress;
        private string dietPercentageString;

        public string dietProgress
        {
            get
            {
                if (_kjIntake < 9000)
                {
                    dietPercentage = dietPercentage + 25;
                    dietPercentageString = dietPercentage.ToString();
                    _dietProgress = "@drawable/flowers" + dietPercentageString;
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
    }
}
