using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_classes
{
    public class cookie
    {
        public double SugarAmount { get; set; }  //called property, is an int, is a part of cookie
        public double FlourAmount { get; set; } //property: double value
        public string CookieType { get; set; }  //proprty: string
        public string CookieShape { get; set; }
        public bool HasNuts { get; set; } //prop: bool
        public List<string> Ingredients { get; set; }
    }
}
