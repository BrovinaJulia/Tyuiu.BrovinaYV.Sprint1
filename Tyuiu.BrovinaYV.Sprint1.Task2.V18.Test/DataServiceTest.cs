using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task2.V18.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 20;
            int z = 4;
            var res = ds.CalculateSideSquareParallelepiped(x, y, z);
            Assert.AreEqual(280, res);
        }
    }
}
