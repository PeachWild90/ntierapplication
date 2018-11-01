using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_11._1_SOLUTION
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string userName = "";
            int userAge = 0;
            int carYear = 0;
            int mileage = 0;
            decimal premium = 0m;
            bool hasAccident = false;

            while (exit == false)
            {
                if (userAge < 25)
                premium = 125m;
                else 
                premium = 75m;

                if(hasAccident)

            }
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
//miles add $50.
//If they have had an accident, add another $25.