using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_04_challenge
{
    class Program

    {   static Person newPerson = new Person();
        static Car newCar = new Car();
        static Car newerCar = new Car();
        static AddCar newaddCar = new AddCar();
         
        static void Main(string[] args)
        {
            bool newaddCar = true;
            if (newaddCar)
            {
                //then add to GetInfo()
            }
            else
            {

            }
            Console.WriteLine("What's up, bro? Welcome to Komodo Insurance");
            Person();
            Car();
            bool running = true;
            while (running)
            {
                Console.WriteLine("A'suh dude, What you trying to do?\n" +
                           "1. See info\n" +
                           "2. Update Info\n" +
                           "3. Add new Car\n" +
                           "4. Exit");
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
                        AddCar();
                        Console.ReadKey();
                        break;
                    case 4:
                        running = false;
                        break;
                   
                    default:
                        Console.WriteLine("Nah dude");
                        break;
                }
            }
        }static void Person()
        {
            Console.WriteLine("Please, supply your address: ");
            string address = Console.ReadLine(); /*"address" has NOTHING TO DO with NewPerson below!!!!!!*/
            Console.WriteLine("Age: ");
            int age = GetIntput();
            Console.WriteLine("first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();

            newPerson = new Person(address, age, firstName, lastName);

            newPerson.FirstName = firstName;
            newPerson.LastName = lastName;
            newPerson.Age = age;
            newPerson.Address = address;
            Console.WriteLine($"Hello {newPerson.FirstName} {newPerson.LastName}! You are {newPerson.Age} years old and live at {newPerson.Address}");
        }

        static void Car()
        {
            Console.WriteLine("What's the make: ");
            string make = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("What's the year: ");
            int year = GetIntput();

            newCar = new Car(make, model, year, newPerson);      
                
            newCar.Make = make;
            newCar.Model = model;
            newCar.Year = year;
            newCar.Owner = newPerson;

            Console.WriteLine($"The make is {newCar.Make}, the model is {newCar.Model} the year is {newCar.Year}");
        }

        static int GetIntput()
        {
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            return input;
        }

        static void GetInfo()
        {
            Console.WriteLine($"Hello {newPerson.FirstName}! Your current informaion is: ");
            Console.WriteLine($"Address: {newPerson.Address}");
            Console.WriteLine($"Make: {newCar.Make}");
            Console.WriteLine($"Model: {newCar.Model}");
            Console.WriteLine($"Year: {newCar.Year}");
 
            Console.WriteLine($"Make: {newaddCar.Make}"); 
        }

        private static void UpdateInfo()
        {
            Person();
        }

        static void AddCar()
        {
            Console.WriteLine("What's the make, fam: ");
            string make = Console.ReadLine();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("What's the year: ");
            int year = GetIntput();

            newaddCar.Make = make;
            newaddCar.Model = model;
            newaddCar.Year = year;
            newCar.Owner = newPerson;
        }
        
    }
}


/*Komodo Insurance is wanting to create a console application 
that allows a user to register their vehicle. Komodo insurance 
needs to know the user's information:
(age, first name, last name, address)
Once Komodo has registered the user,
the user will register their car.
Komodo Insurance needs to know the car's specs:
(brand(honda etc.), 
model(civic, camry etc.), make year, owner(tie to person object)).
Make a person class and a car class.
Allow the user to update information.
Bonus Store multiple owned vehicles to one person object. */

/*1- console app
 *2- register - METHOD
 *3- user(person) - class - age, name, address
 *4- vehicle(car) - class - make, model, year, owner
 *5- update - METHOD */
