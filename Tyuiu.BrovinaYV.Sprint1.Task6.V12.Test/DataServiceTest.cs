using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint1.Task6.V12.Lib;

namespace Tyuiu.BrovinaYV.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "собака кошка собака";
            bool res = ds.CheckLastWordRepetiton(strTest);
            Assert.IsTrue(res);
         
           
        }
    }
}
