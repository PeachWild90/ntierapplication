using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawrence_Challenge
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public int NumOfMovies { get; set; }
        public Decimal TotalCost { get; set; }

        public User(string firstName, string lastName, string address, DateTime birthday,int numOfMovies, Decimal totalCost)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Birthday = birthday;
            NumOfMovies = numOfMovies;
            TotalCost = totalCost;
        }
        public User()
        {
                
        }
    }
}
