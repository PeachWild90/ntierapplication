using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer wylie = new Customer("Wylie", true, 28, 58m); //we are "newing up" a customer

            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            //wylie.Age = age;

            wylie.Age = int.Parse(Console.ReadLine()); //DOES SAME THING AS LINE 15-17! IT'S SHORTHAND!!
            wylie.Age = 28;
            wylie.HasAccidents = true;
            wylie.Name = "Wylie";
            wylie.Premium = 58m;

            Console.WriteLine($"Hello {wylie.Name} your premium is {wylie.Premium}");
            Console.ReadLine();

            Customer trent = new Customer();
            trent.Age = int.Parse(Console.ReadLine());
            trent.Age = 50;
            trent.HasAccidents = true;
            trent.Name = "Trent";
            trent.Premium = 300m;

            trent.Name = "Trent";
            Console.ReadLine();
        }
    }
}
