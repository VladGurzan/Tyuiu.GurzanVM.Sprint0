﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GurzaVM.Sprint0.Task3.V0.Lib;
namespace Tyuiu.GurzaVM.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataSericeTest
    {
        [TestMethod]
        public void CheckedValid()
        {

            Assert.AreEqual(10, DataService.Sum(5, 5));
        } 
    }

}
    