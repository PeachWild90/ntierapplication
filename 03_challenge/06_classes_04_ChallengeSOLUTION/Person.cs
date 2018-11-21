using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_04_ChallengeSOLUTION
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        /*so far we have properties and constructor working in the back */

        public Person(string firstName, string lastName, int age, string address) /*"overloaded"*/
        {
            Address = address;
            LastName = lastName;
            Age = age;
            FirstName = firstName;
        }

        /* when i call this version ^^ i HAVE to put these values in. Can put any variables into here, then givem 2 strings, an int and a string*/
        /*think cookie cutter!! */
        public Person()
        {

        }
    }
}
