using System;
using System.Collections.Generic;
using Challenge5_Copy;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Challenge5Test
{
    [TestClass]
    public class UnitTest1
    {
        CustomerRepository _customerRepo = new CustomerRepository(); //ctrl period -- add reference -- and using statement

        [TestMethod]
        public void CustomerRepository_AddCustomerToList_ShouldIncreaseCountByOne()
        {
            //--Arrange
            Customer customer = new Customer("Bleep", "Bloop", CustomerType.Potential, "lol@gmail.com");
            _customerRepo.AddCutomerToList(customer);
            var list = _customerRepo.GetCustomerList();
            //--Act
            var actual = list.Count;
            var expected = 1;
            //--assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void CustomerRepository_RemoveCustomerFromList_ShouldReduceCountByOne()
        {
            //--Arrange
            Customer customer = new Customer("Bleep", "Bloop", CustomerType.Potential, "lol@gmail.com");
            _customerRepo.AddCutomerToList(customer);
            _customerRepo.RemoveCustomerInfo(customer);
            var list = _customerRepo.GetCustomerList();

            //--Act
            var actual = list.Count;
            var expected = 0;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomerRepository_SortCustomerList_ShouldSortByFirstName()
        {
            //--Arrange
            Customer customer = new Customer("Yaboober", "Hollandaise", CustomerType.Current, "bleepbloop@gmail.com");
            Customer customerTwo = new Customer("Bill", "Jicks", CustomerType.Current, "blah@aol.com");
            Customer customerThree = new Customer("Charles","DeGaul", CustomerType.Current, "derp@gmail.com");
            _customerRepo.AddCutomerToList(customer); //only one parameter at a time
            _customerRepo.AddCutomerToList(customerTwo);
            _customerRepo.AddCutomerToList(customerThree);
            var list = _customerRepo.SortList();


            //--Act
            int actual = list.IndexOf(customerTwo);
            int expected = 0;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
