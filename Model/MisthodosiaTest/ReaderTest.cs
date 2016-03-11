using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Misthodosia;
namespace MisthodosiaTest
{
    [TestClass]
    public class ReaderTest
    {

        [TestMethod]
        public void IdExistsTest()
        {
            //Arrange
            Reader read = new Reader();
            bool expected = true;
            read.PopulateEmployees();
            //Act
            bool actual = read.IdExists(4);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SearchByIdTest()
        {
            //Arrange
            Reader read = new Reader();
            read.PopulateEmployees();
            Employee expected = null; 
            int expected = 4;
            //Act          
            Employee actual = read.SearchById(4);
            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual.ID);
        }
    }
}
