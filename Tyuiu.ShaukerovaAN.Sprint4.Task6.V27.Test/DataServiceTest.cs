using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint4.Task6.V27.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int result = ds.Calculate(mas);
            Assert.AreEqual(1, result);
        }
    }
}
