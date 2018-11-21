using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BearRepository
    {
        private List<Bear> _bears = new List<Bear>();

        public void AddBearToList(Bear bear) //ADD PARAMETERS IE Bear bear
        {
            _bears.Add(bear);
        }

        public void RemoveBearFromList(Bear bear)
        {
            _bears.Remove(bear);
        }

        public List<Bear> GetBearsList() //RETURNS TYPE LIST<BEAR>
        {
            return _bears;
        }
    }
}
