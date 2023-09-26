using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task4.V24.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExrpession()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0.362;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
