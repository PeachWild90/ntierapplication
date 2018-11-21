using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_04_challenge /*PROP *TAB* *TAB* */
{
    class Person
    {
        public string Address { get; set; } /*here we are defining properties. Every instance of Person is going to have these properties*/
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string address, int age, string firstName, string lastName)
        {
            Address = address; /*constructor = variable. Use these as a reference to define an object */
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {

        }
            
     
    }
}

