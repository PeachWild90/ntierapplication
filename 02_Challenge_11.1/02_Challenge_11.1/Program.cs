using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Komodo, we see you wish to buy insurance, we need the name, age and info before we can proceed. What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Excellent, now what is the age of the vehicle?");
            string ageOfCar = Console.ReadLine();
            int actualAge = int.Parse(ageOfCar);

            if (actualAge >= 25)
            {
                Console.WriteLine("That'll be 75$");
            }
            else
            Console.WriteLine("That'll be $125");

            Console.WriteLine("What kinda mileage you got, fam?");
            string mileage = Console.ReadLine();
            int actualMilage = int.Parse(mileage);

            if (actualMilage > 50000)
                Console.WriteLine("$25 has been added to your charge");
            else if (actualMilage > 100000)
                Console.WriteLine("$50 has been added to your charge");

            string response = "y";
            while (response != "n")
            {
                Console.WriteLine("Would you like to register? (y/n)");
                response = Console.ReadLine();
                Console.WriteLine("Would you like to review your information? (y/n)");
                response = Console.ReadLine();
                Console.WriteLine($"Your name is {name}, your car is {ageOfCar} years old");
                Console.WriteLine("Would you like to exit? (y/n)");
                response = Console.ReadLine();

            }




                Console.ReadLine();
        }
    }
}

//Komodo would like an app that allows a user to register for car
//insurance.The app should be able to take in a name, age, and
//information about their vehicle.Komodo wants to charge them $75 
//if they are twenty-five or older and $125 if they are under.
//They also would like a menu that lets the user choose to register,
//see their information, update their information, or exit the
//program.


//Bonus: Komodo would also like to increase the charge based on
//the car's mileage and whether or not they have had an accident.
//If the car is over 50,000 miles add $25, if it is over 100,000 
//miles add $50
//If they have had an accident, add another $25.