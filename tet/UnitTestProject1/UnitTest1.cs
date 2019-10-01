using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tet;

namespace tet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);
            int result2 = Program.Floor((float)-3.4);
            Assert.AreEqual(-4, result2);
            int result3 = Program.Floor(3);
            Assert.AreEqual(3, result3);
        }
    }
}
