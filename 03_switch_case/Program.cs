using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you doing on a scale of 1-5");
            string feeling = Console.ReadLine();
            int input = int.Parse(feeling);

            switch (input)
            {
                case 1:
                    Console.WriteLine("bummer");
                    break;
                case 2:
                    Console.WriteLine("mkay");
                    break;
                case 3:
                    Console.WriteLine("aight den");
                    break;
                case 4:
                    Console.WriteLine("groovy");
                        break;
                case 5:
                    Console.WriteLine("sheeeeeeeeeeeeeeeeeeeeeit");
                    break;
                default:
                    Console.WriteLine("boyakasha");
                    break;
                       
            }

            Console.ReadLine();

            //if (input == 1)
            //{
            //    Console.WriteLine("Bummer, dude");
            //}
            //else if (input == 2)
            //{
            //    Console.WriteLine("sheeeeeit");
            //}

        }
    }
}
