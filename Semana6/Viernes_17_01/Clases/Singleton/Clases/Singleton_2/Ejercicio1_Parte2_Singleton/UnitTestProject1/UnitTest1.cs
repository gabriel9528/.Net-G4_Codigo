using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var finder  = new SingletonFinder();
            var total = finder.GetTotalPopulation(new string[] { "Brasilia", "Lima" });

            Assert.AreEqual(3039444 + 9751717, total);

        }
    }
}
