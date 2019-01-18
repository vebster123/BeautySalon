using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organization;
using ExcelManager;
using System.IO;

namespace DataoTests
{
    [TestClass]
    public class OrganizationTests
    {
        [TestMethod]
        public void CreateHumanWithID()
        {
            // arrange
            uint someRandomID = 123456789;

            // act
            Human Ivan = new Human(someRandomID);

            // assert
            uint actualID = Ivan.About.ID;
            Assert.AreEqual(someRandomID, actualID, "Constructor has failed on Human's ID");
        }

        [TestMethod]
        public void CreateClientWithID()
        {
            // arrange
            uint someRandomID = 123456789;

            // act
            Client Ivan = new Client(someRandomID);

            // assert
            uint actualID = Ivan.About.ID;
            Assert.AreEqual(someRandomID, actualID, "Constructor has failed on Human's ID");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TableFaultyPathTest()
        {
            // arrange
            FileInfo path = new FileInfo(@"C:/random_folder/random.xlsx");

            // act
            Table.FillTable(path);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SaveEmptyTable()
        {
            // arrange

            // act
            Table.Update();

            // assert is handled by ExpectedException
        }

    }
}
