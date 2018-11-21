using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Challenge
{
    class TV
    {
        public string TVName { get; set; }
        public int TVRating { get; set; }
        public string TVGenre { get; set; }

        public TV(string tvName, int tvRating, string tvGenre)
        {
            TVName = tvName;
            TVRating = tvRating;
            TVGenre = tvGenre;
        }

        public TV()
        {

        }
    }

    
}
