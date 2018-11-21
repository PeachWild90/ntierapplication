using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lawrence_Challenge
{
    public class KrunkerUI
    {
        KrunkerRepository _userRepo = new KrunkerRepository();
        List<User> _listOfUsers;
        public void Run()
        {
            _listOfUsers = _userRepo.GetUserList();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("hello, friendo" +
                    "\n1. Create a User" +
                    "\n2. Remove User" +
                    "\n3. Display All Users by Last Name");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateUser();
                        break;
                    case 2:
                        RemoveUser();
                        break;
                    case 3:
                        DisplayList();
                        break;
                }
            }
        }
        private void CreateUser()
        {
            User newUser = new User();
            Console.WriteLine("First Name: ");
            newUser.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            newUser.LastName = Console.ReadLine();

            Console.WriteLine("Address: ");
            newUser.Address = Console.ReadLine();

            Console.WriteLine("Birthday: ");
            newUser.Birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Number of Videos Bought: ");
            newUser.NumOfMovies = int.Parse(Console.ReadLine());

            Console.WriteLine("Each video is $10, therefore the total cost is: ");
            newUser.TotalCost = decimal.Parse(Console.ReadLine());
        }

        private void RemoveUser()
        {
            Console.WriteLine("Which user would you like to remove?");
            string User = Console.ReadLine();

            foreach (User user in _listOfUsers.ToList())
            {
                if (user.FirstName == User)
                {
                    _userRepo.RemoveUserFromList(user);
                }
            }
            return;
        }

        private void DisplayList()
        {
            _userRepo.SortList();
            var FirstName = "FirstName";
            var LastName = "LastName";
            var Address = "Address";
            var Birthday = "Birthday";
            var NumOfMovies = "NumOfMovies";
            var TotalCost = "TotalCost";

            List<User> userList = _userRepo.GetUserList();
            Console.WriteLine($"{FirstName, -15} {LastName, -15} {Address, -15} {Birthday, -15} {NumOfMovies, -15} {TotalCost, -15}");

            foreach (var user in userList)
            {
                Console.WriteLine($"{user.FirstName, -15} {user.LastName, -15} {user.Address, -15} {user.Birthday, -15} {user.NumOfMovies, -15} {user.TotalCost, -15}");
            }
        }
    }
}