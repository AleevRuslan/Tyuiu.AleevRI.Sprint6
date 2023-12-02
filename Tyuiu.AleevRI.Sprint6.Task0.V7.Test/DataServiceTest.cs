using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AleevRI.Sprint6.Task0.V7.Lib;

namespace Tyuiu.AleevRI.Sprint6.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 5;
            double res = ds.Calculate(x);
            double wait = 0.625;
            Assert.AreEqual(wait, res);
        }
    }
}
