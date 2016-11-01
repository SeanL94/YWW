using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWW.core.Interfaces;

namespace YWW.core.ViewModels
{
    public class ProfileMainViewModel : MvxViewModel
    {
        public ICommand GoToEdit { get; private set; }
        public ICommand GoToHealthPlan { get; private set; }
        //public ICommand GoToCommunity { get; private set; }
        public ICommand GoToMain { get; private set; }
        public ICommand GoToProfile { get; private set; }
        public ICommand GoToPost { get; private set; }
        private readonly IUserDatabase userDatabase;
        public ProfileMainViewModel(IUserDatabase userDatabase)
        {
            this.userDatabase = userDatabase;
            getUserInfo();
            if (FirstName != null)
            {
                IllnesHistory = FirstName + " fought breast cancer for 5 years and finaly beat last year. You have come a long way and we will help you to get even more better. Attending doctor is Dr. ...";
            }
            GoToEdit = new MvxCommand(() =>
            {
                ShowViewModel<ProfileEditViewModel>();
            });
            GoToHealthPlan = new MvxCommand(() =>
            {
                ShowViewModel<HealthPlanViewModel>();
            });
            GoToMain = new MvxCommand(() =>
            {
                ShowViewModel<FirstViewModel>();
            });
            GoToProfile = new MvxCommand(() =>
            {
                ShowViewModel<ProfileMainViewModel>();
            });
            GoToPost = new MvxCommand(() =>
            {
                ShowViewModel<ThoughtViewModel>();
            });
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value != null && value != _firstName)
                {
                    _firstName = value;
                    RaisePropertyChanged(() => FirstName);
                    RaisePropertyChanged(() => FullName);
                }
            }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value != null && value != _lastName)
                {
                    _lastName = value;
                    RaisePropertyChanged(() => LastName);
                    RaisePropertyChanged(() => FullName);
                }
            }
        }
        public string FullName
        {
            get { return string.Format(@"{0} {1}", _firstName, _lastName); }
        }
        private string _day;
        public string Day
        {
            get { return _day; }
            set
            {
                if (value != null && value != _day)
                {
                    _day = value;
                    RaisePropertyChanged(() => Day);
                    RaisePropertyChanged(() => Birthday);
                }
            }
        }
        private string _month;
        public string Month
        {
            get { return _month; }
            set
            {
                if (value != null && value != _month)
                {
                    _month = value;
                    RaisePropertyChanged(() => Month);
                    RaisePropertyChanged(() => Birthday);
                }
            }
        }
        private string _year;
        public string Year
        {
            get { return _year; }
            set
            {
                if (value != null && value != _year)
                {
                    _year = value;
                    RaisePropertyChanged(() => Year);
                    RaisePropertyChanged(() => Birthday);
                }
            }
        }
        public string Birthday
        {
            get { return string.Format(@"{0} / {1} / {2}", _day, _month, _year); }
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
        private string _street;
        public string Street
        {
            get { return _street; }
            set
            {
                if (value != null && value != _street)
                {
                    _street = value;
                    RaisePropertyChanged(() => Street);
                    RaisePropertyChanged(() => Address);
                }
            }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                if (value != null && value != _city)
                {
                    _city = value;
                    RaisePropertyChanged(() => City);
                    RaisePropertyChanged(() => Address);
                }
            }
        }
        private string _postcoad;
        public string Postcoad
        {
            get { return _postcoad; }
            set
            {
                if (value != null && value != _postcoad)
                {
                    _postcoad = value;
                    RaisePropertyChanged(() => Postcoad);
                    RaisePropertyChanged(() => Address);
                }
            }
        }
        private string _suburb;
        public string Suburb
        {
            get { return _suburb; }
            set
            {
                if (value != null && value != _suburb)
                {
                    _suburb = value;
                    RaisePropertyChanged(() => Suburb);
                    RaisePropertyChanged(() => Address);
                }
            }
        }
        public string Address
        {
            get { return string.Format(@"{0} {1} {2} {3}", _street, _city, _postcoad, _suburb); }
        }
        private string _imageURL;
        public string ImageURL
        {
            get { return _imageURL; }
            set { SetProperty(ref _imageURL, value); }
        }
        private string _illnesHistory;
        public string IllnesHistory
        {
            get { return _illnesHistory; }
            set { SetProperty(ref _illnesHistory, value); }
        }

        public async void getUserInfo()
        {
            var user = await userDatabase.GetUser();
            foreach (var u in user)
            {
                FirstName = u.FirstName;
                LastName = u.LastName;
                Day = u.Day;
                Month = u.Month;
                Year = u.Year;
                Hobbies = u.Hobbies;
                Interests = u.Interests;
                Street = u.Street;
                City = u.City;
                Postcoad = u.Postcoad;
                Suburb = u.Suburb;
            }
        }

    }
}
