using SQLite.Net.Attributes;
using System;

namespace YWW.core.Models
{
    [Table("User")]
    public class User
    {

        public User() { }
        public User(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Day = user.Day;
            Month = user.Month;
            Year = user.Year;
            Hobbies = user.Hobbies;
            Interests = user.Interests;
            Street = user.Street;
            City = user.City;
            Postcoad = user.Postcoad;
            Suburb = user.Suburb;
            ImageURL = user.ImageURL;
        }

        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Hobbies { get; set; }
        public string Interests { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcoad { get; set; }
        public string Suburb { get; set; }
        public string ImageURL { get; set; }
    }
}
