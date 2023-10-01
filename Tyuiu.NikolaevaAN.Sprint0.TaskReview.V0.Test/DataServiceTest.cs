using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaevaAN.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.NikolaevaAN.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 1;
            int y = 2;
            int z = 3;
            int res = DataService.Calc(x, y, z);
            Assert.AreEqual(30, res);
        }
    }
}
