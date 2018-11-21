using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Challenge
{
    class Movies
    {
        public string MovieName { get; set; }
        public int MovieRating { get; set; }
        public string Genre { get; set; }

        public Movies(string movieName, int movieRating, string genre)
        {
            MovieName = movieName; /*constructor = variable. Use these as a reference to define an object */
            MovieRating = movieRating;
            Genre = genre;
        }

        public Movies()
        {

        }
    }

}
