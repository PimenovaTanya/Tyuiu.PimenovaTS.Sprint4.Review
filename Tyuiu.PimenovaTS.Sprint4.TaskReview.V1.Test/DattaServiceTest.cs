using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint4.TaskReview.V1.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.TaskReview.V1.Test
{
    [TestClass]
    public class DattaServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int kols = 3;
            int kolst = 3;
            int[,] zombi = new int[kols, kolst];
            string buk = "135792468";
            DataService ds = new DataService();
            int res = ds.Calculate(kols, kolst, buk);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
