using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mess_around
{
    [TestClass]
    public class BearTest
    {
        BearRepository _bearRepo = new BearRepository();

        [TestMethod]
        public void BearRepository_AddBearToList_ShouldIncreaseCountByOne()
        {
            //--Arrange
            Bear bear = new Bear("Beary", BearSize.Medium, false, "Brown");
            _bearRepo.AddBearToList(bear);
            var list = _bearRepo.GetBearsList();  //this list = the list in the repository
            //create a bear, adding to repo, testing whether it actually worked
            

            //--Act
            var actual = list.Count;
            var expected = 1;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BearRepository_RemoveBearFromList_ShouldReduceCOuntByOne()
        {
            //--Arrange
            Bear bear = new Bear("Beary", BearSize.Medium, false, "Brown");
            var list = _bearRepo.GetBearsList();
            _bearRepo.AddBearToList(bear); //NEED THIS BC U GOTTA ADD SOMETHING TO REMOVE IT
            _bearRepo.RemoveBearFromList(bear);

            //--Act
            var actual = list.Count;
            var expected = 0;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
// DONT NEED GET METHODS BC U USE THEM HERE DUHHHHH!!!!