using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes_03
{
    class Customer //internal is "implied"
    {
        public string Name { get; set; }
        public bool HasAccidents { get; set; }
        public int Age { get; set; }
        public decimal Premium { get; set; }

        public Customer(string name, bool hasAccident, int age, decimal premium) //ctor "constructor" we are building. If it is empty we call it "open". also called Object Initialization Syntax
        {
            Name = name;
            HasAccidents = hasAccident;
            Age = age;
            Premium = premium;
        }

        public Customer()
        {

        }
    }
}
