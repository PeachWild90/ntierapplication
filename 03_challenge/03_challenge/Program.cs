using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_challenge
{
    class Program
    {
        static int userAge = 0;
        static string userName = "";
        static int userAccident = 0;
        static int userMileage = 0;
        static decimal totalCost = 0m;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Komodo, fam.");
            Register();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do today?\n" + "1. Display Information.\n" + "2. Update Information.\n" + "3. Exit der Program.\n");

                int input = GetIntput();

                switch (input)
                { 
                    case 1:
                    GetInfo();
                    Console.ReadKey();
                    break;

                case 2:
                    UpdateInfo();
                    Console.ReadKey();
                    break;

                case 3:
                    running = false;
                    break;

                default:
                    Console.WriteLine("omg wat r u doing");
                    break;
                }
            }
        }

        static int GetIntput()
        {
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            return input;
        }

        static void Register()
        {
            Console.WriteLine("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("How old is the vehicle? ");
            userAge = GetIntput();
            Console.WriteLine("How many accidents have you been in? ");
            userAccident = GetIntput();
            Console.WriteLine("What is your mileage? ");
            userMileage = GetIntput();

            CalculateCost();

        }
        static void GetInfo()
        {
            Console.WriteLine($"Wassap {userName}?? Your current information is: ");
            Console.WriteLine($"Vehicle age: {userAge}");
            Console.WriteLine($"Mileage: {userMileage}");
            Console.WriteLine($"Total Cost: {totalCost}");
        }

        static void UpdateInfo()
        {
            Register();
        }

        static void CalculateCost()
        {
            decimal ageCost;
            decimal ageMileage;
            decimal ageAccident;

            if (userAge >= 25)
            {
                ageCost = 75;
            }
            else
                ageCost = 125;

            if (userMileage > 50000)
            {
                ageMileage = 25;
            }
            else if (userMileage > 100000)
            {
                ageMileage = 50;
            }
            else
            {
                ageMileage = 0;
            }
            if (userAccident > 0)
            {
                ageAccident = 25;
            }
            else
            {
                ageAccident = 0;
            }

            totalCost = ageCost + ageMileage + ageAccident;
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

//New Items: Write a method to calculate their premium.Feel free to
//explore and write any other methods you feel could be helpful.


//Bonus: Komodo would also like to increase the charge based on
//the car's mileage and whether or not they have had an accident.
//If the car is over 50,000 miles add $25, if it is over 100,000 
//miles add $50.

//If they have had an accident, add another $25.

//1-user registers - name, age and info about vehicle
//2-75$ if they are 25+ and $125 if under
//3-menu-choose to register, see their info, update their info, or exit