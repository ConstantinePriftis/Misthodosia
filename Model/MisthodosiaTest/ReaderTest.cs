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
            int expected = 4;
            //Act          
            Employee actual = read.SearchById(4);
            //Assert
            Assert.AreEqual(expected, actual.ID);
        }
       
        //public void LessWageTest()
        //{
        //    //Arrange
        //    Reader read = new Reader();
        //    //Act
        //    Employee actual = read.LessWage(1500);
        //    //Assert
        //    Assert.IsNotNull(actual);
        //}
        //[TestMethod]
        //public void MoreWageTest()
        //{
        //    //Arrange
        //    Reader read = new Reader();
        //    //Act
        //    Employee actual = read.MoreWage(2000);
        //    //Assert
        //    Assert.IsNotNull(actual);  
        //}
        

    }
}
