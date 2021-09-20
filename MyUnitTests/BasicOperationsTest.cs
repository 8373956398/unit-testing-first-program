using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace MyUnitTests
{
    [TestClass]
    public class BasicOperationsTest
    {
        [TestMethod]
        //Addition
        public void TestAdd()
        {
            //Assemble
            MyPrograms.BasicOperations basicOperations = new MyPrograms.BasicOperations();
            int expectedResult = 5;

            //Act
            int actuallResult = basicOperations.Add(2, 3);
            //Assert
            Assert.AreEqual(expectedResult, actuallResult);
        }

        [TestMethod]
        //multipilcation
        public void TestMul()
        {
            //Assemble
            MyPrograms.BasicOperations basicOperations = new MyPrograms.BasicOperations();
            int expectedResult = 14;

            //Act
            int actuallResult = basicOperations.Mul(7, 2);
            //Assert
            Assert.AreEqual(expectedResult, actuallResult);
        }


        [TestMethod]
        //Division
        public void TestDiv()
        {
            //Assemble
            MyPrograms.BasicOperations basicOperations = new MyPrograms.BasicOperations();
            int expectedResult = 3;

            //Act
            int actuallResult = basicOperations.Div(15, 5);
            //Assert
            Assert.AreEqual(expectedResult, actuallResult);
        }

        [TestMethod]
        //Subtraction
        public void TestSub()
        {
            //Assemble
            MyPrograms.BasicOperations basicOperations = new MyPrograms.BasicOperations();
            int expectedResult = 2;

            //Act
            int actuallResult = basicOperations.Sub(7, 5);
            //Assert
            Assert.AreEqual(expectedResult, actuallResult);
        }
    }
}
