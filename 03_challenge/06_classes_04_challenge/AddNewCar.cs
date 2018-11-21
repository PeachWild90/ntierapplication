using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_04_challenge
{
    class AddCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Person Owner { get; set; }

        public AddCar(string make, string model, int year, Person owner)
        {
            Make = make;
            Model = model;
            Year = year;
            Owner = owner;
        }

        public AddCar()
        {

        }
    }

}
