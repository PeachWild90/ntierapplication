using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Pet
    {               /*PROPERTY*/
        public string Name { get; set; }
        public int LegCount { get; set; }
        public string Breed { get; set; }
        public bool IsClean { get; set; }

        //ctor builds constructor

        public Pet(string name, int legs, string breed, bool clean)
        {
            Name = name; /*<<<<gets passed through constructor*/
            LegCount = legs;
            Breed = breed;
            IsClean = clean;
        }

    }
}
