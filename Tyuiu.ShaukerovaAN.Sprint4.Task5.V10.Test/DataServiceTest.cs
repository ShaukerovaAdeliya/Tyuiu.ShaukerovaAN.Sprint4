using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint4.Task5.V10.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]{{0, 0, 0, 0, 0 },

                                        { 0, 7, 0, 0, 0 },

                                        {0, 0, 0, 1, 5 },

                                        { 1, 7, 0, 5, 7 },

                                        { 0, 2, 0, 5, 0 }
            };
            int result = ds.Calculate(array);
            int wait = 40;
            Assert.AreEqual(wait, result);
        }
    }
}
