using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you, bro?");
            string ageAsString = Console.ReadLine();
            int actualAge = int.Parse(ageAsString);

            if(actualAge < 18)
            {
                Console.WriteLine("I bet you like Imagine Dragons");
            }

            if(actualAge == 18)
            {
                Console.WriteLine("oh no no no no no...");
            }

            if (actualAge != 18)
            {
                Console.WriteLine("bruh look at this dude");
            }

            if (actualAge >= 18 && actualAge < 65)
            {
                Console.WriteLine("I hope you do not like Imagine Dragons...");
            }

            if (actualAge <18 || actualAge > 25)
            {
                Console.WriteLine("zoomer status *activated*");
            }
            Console.ReadLine();
        }
    }
}
