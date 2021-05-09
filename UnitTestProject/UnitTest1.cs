using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoRent_system;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        database obj_database = new database();
        [TestMethod]
        public void First_Test_Case()
        {
            int rental_Cost = obj_database.rentCost(5, "2020");
            Assert.AreEqual(5, rental_Cost);

        }

        [TestMethod]
        public void Second_Test_Case()
        {
            int rental_Cost = obj_database.rentCost(5, "2010");
            Assert.AreNotEqual(5, rental_Cost);

        }
    }
}
