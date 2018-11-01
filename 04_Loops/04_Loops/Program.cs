using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)

            //i+=5 i = i + 5
        {   //        1        2     3
            //for (start  condition  this ends loop)
            //for loops used for numbers mostly

            string name = "Zardoz";

            for (int i = 1; i <= name.Length; i++)
            {
                Console.WriteLine(i);
            }

             foreach(char letter in name)
            {
                Console.WriteLine(letter);
            }

            int total = 1;
            while(total != 5)
            {
                Console.WriteLine(total);
                total++;
                break;
            }



            Console.ReadLine();
        }
    }
}
