using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GurzanVM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GurzanVM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            var name = "Влад";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Влад", res);

        }
    }
}
