using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace MyUnitTests
{
    [TestClass]
    public class ClassicProgramsTest
    {
        //IsPrime
        [TestMethod]
        public void TestIsPrime()
        {
            //Assemble
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool ExpectedResult = true;
            //Act
            bool ActualResult = classicPrograms.IsPrime(5);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        //IsEven
        [TestMethod]
        public void TestIsEven()
        {
            //Assemble
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool ExpectedResult = true;
            //Act
            bool ActualResult = classicPrograms.IsEven(2);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        //IsOdd
        [TestMethod]
        public void TestIsOdd()
        {
            //Assemble
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool ExpectedResult = true;
            //Act
            bool ActualResult = classicPrograms.IsOdd(5);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);

        }
    }
}
