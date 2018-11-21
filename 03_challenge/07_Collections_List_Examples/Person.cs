using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_List_Examples
{
    class Person
    {
        public string FullName { get; set; }
        public List<Car> CarList { get; set; }

        public Person(string name, List<Car> carList)
        {
            FullName = name;
            CarList = carList;

        }

        public Person()
        {
            CarList = new List<Car>(); //when u initialize your person, hit the constructor, it will execute this code. it will be an empty list, but an initialized one!!!!!
        }
    }
}
                                                //why do we have a list of cars in constructor?
                                               //if we have multiple people, lists, cars
                                              //So we know who owns the car(s)
                                             //we INCLUDE this with our person(s)
    