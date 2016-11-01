using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWW.core.Interfaces;
using YWW.core.Models;

namespace YWW.core.ViewModels
{
    public class ProfileEditViewModel : MvxViewModel
    {
        private IUserDatabase localdb;
        public ICommand Save { get; private set; }
        public ProfileEditViewModel(IUserDatabase db)
        {
            localdb = db;
            Save = new MvxCommand(() =>
            {
                InsertUser();
                ShowViewModel<ProfileMainViewModel>();
            });
        }
        public async void InsertUser()
        {
            var newUser = (new User
            {
                FirstName = FirstName,
                LastName = LastName,
                Day = Day,
                Month = Month,
                Year = Year,
                Hobbies = Hobbies,
                Interests = Interests,
                Street = Street,
                City = City,
                Postcoad = Postcoad,
                Suburb = Suburb,
                ImageURL = ImageURL
            });
            if (localdb.Equals(null))
                await localdb.CreateUser(newUser);
            else
                await localdb.UpdateUser(newUser);
        }
        private string _firstName = "";
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
        private string _lastName = "";
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
        private string _day = "";
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
        private string _month = "";
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
        private string _year = "";
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

        private string _hobbies = "";
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
        private string _interests = "";
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
        private string _street = "";
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
        private string _city = "";
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
        private string _postcoad = "";
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
        private string _suburb = "";
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
            set
            {
                _imageURL = value;
                RaisePropertyChanged(() => ImageURL);
            }
        }
    }
}
