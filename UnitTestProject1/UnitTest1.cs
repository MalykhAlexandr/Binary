using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNegativeNumbers()
        {
            int[] negativeNumbers = new int[] { -5, -4, -3, -2 };
            Assert.AreEqual(0, Program.BinarySearch(negativeNumbers, -5));
        
    }
}
