using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5_Copy
{
   public class CustomerRepository
    {
        List<Customer> _listOfCustomerInfo = new List<Customer>();

        public void AddCutomerToList(Customer info)
        {
            _listOfCustomerInfo.Add(info); //passing in parameter ie info

        }

        public List<Customer> GetCustomerList()
        {
            return _listOfCustomerInfo;
        }

        public void RemoveCustomerInfo(Customer info)
        {
            _listOfCustomerInfo.Remove(info);
        }
        public CustomerRepository()
        {

        }
        public List<Customer> SortList()
        {
            List<Customer> _sortedList = _listOfCustomerInfo.OrderBy(x => x.FirstName).ToList();

            _listOfCustomerInfo = _sortedList;

            return _sortedList;
        }
    }
}
