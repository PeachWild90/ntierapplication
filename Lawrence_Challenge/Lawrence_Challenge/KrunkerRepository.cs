using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawrence_Challenge
{
    class KrunkerRepository
    {
        List<User> _listOfUsers = new List<User>();

        public void AddUserToList(User user)
        {
            _listOfUsers.Add(user);
        }

        public void RemoveUserFromList(User user)
        {
            _listOfUsers.Remove(user);
        }

        public List<User> GetUserList()
        {
            return _listOfUsers;
        }

        public void SortList()
        {
            List<User> _sortedList = _listOfUsers.OrderBy(x => x.LastName).ToList();

            _listOfUsers = _sortedList;
        }
        public KrunkerRepository()
        {

        }
    }
}
