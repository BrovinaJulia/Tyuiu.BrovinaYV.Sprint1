﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task1.V2.Lib;
namespace Tyuiu.BrovinaYV.Sprint1.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 14.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4, res);
        }
    }
}
