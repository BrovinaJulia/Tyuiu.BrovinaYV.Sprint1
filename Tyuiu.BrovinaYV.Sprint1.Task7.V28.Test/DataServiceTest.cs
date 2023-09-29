using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task7.V28.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait =16.787;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
