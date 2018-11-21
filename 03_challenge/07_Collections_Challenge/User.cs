using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Challenge
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Movies> MovieList { get; set; }
        public List<TV> TVList { get; set; }

        public User(string firstName, string lastName, int age, List<Movies> movieList, List<TV> tvList)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MovieList = movieList;
            MovieList = new List<Movies>();
            TVList = new List<TV>();
        }

        public User()
        {
            
        }
    }
}
