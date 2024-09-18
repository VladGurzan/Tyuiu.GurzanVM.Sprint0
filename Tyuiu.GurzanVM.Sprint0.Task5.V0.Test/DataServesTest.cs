using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurzanVM.Sprint0.Task5.V0.Lib;

namespace Tyuiu.GurzanVM.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServesTest
    {
        [TestMethod]
         public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataServes.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataServes.Subtraction(10, 5));
        }


        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataServes.Multiplication(10, 5));
        }


        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataServes.Division(9, 3));
        }

    }
}
