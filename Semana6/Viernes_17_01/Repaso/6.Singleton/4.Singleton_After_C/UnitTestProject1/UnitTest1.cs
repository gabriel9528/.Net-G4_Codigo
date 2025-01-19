using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton_Before;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var finder = new SingletonFinder(new DummyDataBase());
            var total = finder.GetTotalPopulation(new string[] { "Brasilia", "Lima" });

            Assert.AreEqual(3039444 + 9751717, total);
        }
    }
}
