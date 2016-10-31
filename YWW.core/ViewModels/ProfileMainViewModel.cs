using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YWW.core.ViewModels
{
    public class ProfileMainViewModel : MvxViewModel
    {
        public ICommand GoToEdit { get; private set; }
        public ICommand GoToHealthPlan { get; private set; }
        public ICommand GoToCommunity { get; private set; }
        public ICommand GoToMain { get; private set; }
        public ICommand GoToProfile { get; private set; }
        public ProfileMainViewModel()
        {
            GoToEdit = new MvxCommand(() =>
            {
                ShowViewModel<ProfileEditViewModel>();
            });
            GoToHealthPlan = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
            GoToMain = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
            GoToProfile = new MvxCommand(() =>
            {
                ShowViewModel<ProfileMainViewModel>();
            });
        }
        public void Init(string FullName, string Birthday, string Hobbies, string Interests, string Address)
        {
            this.FullName = FullName;
            this.Birthday = Birthday;
            this.Hobbies = Hobbies;
            this.Interests = Interests;
            this.Address = Address;
        }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (value != null && value != _fullName)
                {
                    _fullName = value;
                    RaisePropertyChanged(() => FullName);
                }
            }
        }
        private string _birthday;
        public string Birthday
        {
            get { return _birthday; }
            set
            {
                if (value != null && value != _birthday)
                {
                    _birthday = value;
                    RaisePropertyChanged(() => Birthday);
                }
            }
        }
        private string _hobbies;
        public string Hobbies
        {
            get { return _hobbies; }
            set
            {
                if (value != null && value != _hobbies)
                {
                    _hobbies = value;
                    RaisePropertyChanged(() => Hobbies);
                }
            }
        }
        private string _interests;
        public string Interests
        {
            get { return _interests; }
            set
            {
                if (value != null && value != _interests)
                {
                    _interests = value;
                    RaisePropertyChanged(() => Interests);
                }
            }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                if (value != null && value != _address)
                {
                    _address = value;
                    RaisePropertyChanged(() => Address);
                }
            }
        }
    }
}
