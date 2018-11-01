using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types //addresses assembly
{
    class Program
    {
        static void Main(string[] args) //funcions == methods// 
        {
            //type name = value
            //declaring a variable
            bool isTall;

            //isTall=false
            int age;

            byte low = 0;
            byte high = 225;

            float floating = 123.421f;
            double doubling = 123.54345d;
            decimal deci = 192.999999999999m;

            //Int16 == short
            //Int64 == long
            long number3 = 123;

            char character = 'a';
            string word = "this is a string, bro";

            Console.WriteLine("word");
            Console.WriteLine(word);

         
            //string input = Console.ReadLine(); // . = DOT OPERATOR that CALLS the READ LINE on the CONSOLE
            //Console.WriteLine(input);

            Console.WriteLine("what is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Your first name is " + firstName);

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Sheeeit your last name is tight. I wish mine was " + lastName);

            Console.WriteLine("How old are you, bro?");
            string myAge = Console.ReadLine();
            Console.WriteLine("Damn, bro " + myAge + " is old as hell");

            //console.writeline("how old are you?"
            //string meAgeAsAString = Console.ReadLine()
            //int myIntAge = int.Parse(meAgeAsaString);
            //myIntAge = Convert.ToInt32(meAgeAsAString);


            Console.WriteLine("wats yur email, dawg?");
            string meEmail = Console.ReadLine();
            Console.WriteLine("Your email is " + meEmail);

            Console.WriteLine("Press any key to put it all together");
            Console.ReadLine();
            Console.WriteLine("Your name is " + firstName + " " + lastName + ".");
            Console.WriteLine("You are " + myAge + " years old and your email is " + meEmail);

            Console.ReadLine(); //THIS GOES LINE BY LINE THEN CLOSES WITHOUT A LEWP!
        }
    }
}