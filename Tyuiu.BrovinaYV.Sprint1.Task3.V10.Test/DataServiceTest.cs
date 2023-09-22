using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 26.6;
            var res = ds.NumberToMoney(x);
            Assert.AreEqual(26,60, res);
        }
    }
}
