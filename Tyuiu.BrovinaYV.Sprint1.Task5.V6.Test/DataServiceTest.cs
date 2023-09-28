using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExrpession()
        {
            DataService ds = new DataService();
            int k = 18;
            int wait = 4;
            var res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
