using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_04_ChallengeSOLUTION
{
    class Program
    {
        static void Main(string[] args)
        {

            Person personOne = new Person("Ransford", "Walker", 27, "123 home st");

            Person wylie = new Person();
            wylie.FirstName = "Wylie";
            wylie.LastName = "Peach";
            wylie.Age = 28;                     /*THIS WAY IS SLOW */
            wylie.Address = "501 w 62";

            Person personThree = new Person()
            {
                FirstName = "John",
                LastName = "Miller",
                Age = 28,
                Address = "828 Beer Blvd"
            };
            /*these are ways to construct a person */

            Car carOne = new Car(2019, "Volvo", "S70", wylie);

            Car carTwo = new Car()
            {
                Year = 1995,
                Make = "Toyota",
                Model = "Corrolla",
                Owner = personThree
            };
            
        }
    }
}
