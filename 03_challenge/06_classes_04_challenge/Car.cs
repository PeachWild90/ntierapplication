using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_04_challenge
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Person Owner { get; set; }

        public Car(string make, string model, int year, Person owner)
        {
            Make = make;
            Model = model;
            Year = year;
            Owner = owner;
        }

        public Car()
        {

        }
    }

    //public car()  constructor!!!!!
    //{

    //}
}
