using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Тест_21_30
{
    [TestClass]
    public class TestMass
    {
        [TestMethod]
        public void TestMethodProcess()
        {
            MassivBezDll.mass = new long[] {10,10,10,10,10,10,10,10,10,10 };
            long expected = 100;
            MassivBezDll.Process();
            Assert.AreEqual(expected, MassivBezDll.sum);
        }
    }
}
