using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum BearSize {  Small = 1, Medium, Large, Huge}
    public class Bear
    {
        public BearSize SizeOfBear { get; set; }
        public bool IsHibernating { get; set; }
        public string Color { get; set; }

        public Bear(string v, BearSize size, bool isHibernating, string color)
        {
            SizeOfBear = size;
            IsHibernating = isHibernating;
            Color = color;
        }
        public Bear(string v, BearSize medium)
        {

        }
    }
}
