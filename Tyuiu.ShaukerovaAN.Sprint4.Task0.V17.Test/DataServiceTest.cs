using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint4.Task0.V17.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWaitArray = 34;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
