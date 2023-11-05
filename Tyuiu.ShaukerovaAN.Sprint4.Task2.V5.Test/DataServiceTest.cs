using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint4.Task2.V5.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 8, 4, 9, 7};

            int res = ds.Calculate(numsArray);
            int wait = 24576;

            Assert.AreEqual(wait, res);
        }
    }
}
