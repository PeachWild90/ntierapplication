using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, friendo, we see you have a car to sell, what is the age of the car?");
            string ageOfCar = Console.ReadLine();
            int actualAge = int.Parse(ageOfCar);

            if (actualAge > 15)
            {
                Console.WriteLine("Old car, bro, we'll give u $150 for it.");
            }
            else if (actualAge >= 5 && actualAge <= 15)
            {
                Console.WriteLine("We'll give u $100");
            }
            else
            {
                Console.WriteLine("75$, how about dat?");
            }
            Console.ReadLine();
        }
    }
}
