using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern
{
   public class StreamingContent
    {
        //properties
        public string Title { get; set; }
        public int Rating { get; set; }
        public string Genre { get; set; }
        public bool IsMature { get; set; }

        //why does it need a constructor? initialize all member variables when an object of this class is created. Any resources acquired such as memory or open files are typically released in the class destructor.
        public StreamingContent(string title, string genre, int rating, bool isMature)
        {
            Title = title; //type is already stated above
            Genre = genre;
            Rating = rating;
            IsMature = isMature;
        }

        public StreamingContent() //why do we want 2 constructors? Instead of requiring all 4, maybe you only want 1 or 2. 
                                  //If you have open one, you can add them one at a time.
        {

        }
    }
}
