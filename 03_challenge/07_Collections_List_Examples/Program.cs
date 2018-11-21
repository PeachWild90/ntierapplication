using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_List_Examples
{
    class Program
    {
        static Person firstPerson = new Person();

        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            //string name = Console.ReadLine();  ======= redundant
            firstPerson.FullName = Console.ReadLine();

            Console.WriteLine("Do you have a car? (y/n)");
            //get input, need a condition for multiple cars for one person
            
            string input = Console.ReadLine();
            bool addingCars = true;   
            while (addingCars)
            {
                switch (input)
                {
                    case "y":
                        RegisterCar();
                        break;
                    case "n":
                        addingCars = false; //make it false so when we get to while loop it doesnt fire off
                        break;
                }

                while (addingCars)
                {
                    Console.WriteLine("Do you want to add another car?");
                    //use same input as before
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "y":
                            RegisterCar();
                            break;
                        case "n":
                            addingCars = false; //make it false so when we get to while loop it doesnt fire off
                            break;
                    }
                }
            }

            Console.ReadLine();
        }

        //static void CheckAnswer(string input) //when we call checkanswer we will pass the Input
        //{
        //    switch (input)
        //    {
        //        case "y":
        //            RegisterCar();
        //            break;
        //        case "n":
        //            addingCars = false; //make it false so when we get to while loop it doesnt fire off
        //            break;
        //    }
        //}

        static void RegisterCar()
        {
            Car newCar = new Car();                             //where do we want to save it?
            Console.WriteLine("what is the make of your car?"); //WHERE SHOULD WE MAKE OUR CAR? WHY IN HERE?
            newCar.CarMake = Console.ReadLine();                //If you create a car inside a registered car it will call
                                                                //It's a NEW INSTANCE, which means, ALL of our info gets saved
                                                                //Every time we call RegisterCar we make a NEW CAR

            Console.WriteLine("what is the model?");
            newCar.CarModel = Console.ReadLine();

            firstPerson.CarList.Add(newCar);
        }
    }
}           //Instead of making a car up top, we are saving it in these people.
            //how do we add it to the list?
            //Call me person's name by accessing the list "." gives me access, granting me access to LISTS
            //What do we pass into Add()? newCar!!!!! because we registering a new car!