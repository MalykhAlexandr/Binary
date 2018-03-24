using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binary;

namespace UnitTestProjec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
            public void NegativeNumbers()
        {
            int[] negativeNumbers = new int[] { -5, -4, -3, -2 };
            Assert.AreEqual(0, Program.BinarySearch(negativeNumbers, -5));
        }

        [TestMethod]
            public void NonExistentElement()
        {
            int[] negativeNumbers = new int[] { -5, -4, -3, -2 };
            Assert.AreEqual(-1, Program.BinarySearch(negativeNumbers, -6));
        }

        [TestMethod]
        public void EmptyArray()
        {
            int[] numbers = new int[] {  };
            Assert.AreEqual(-1, Program.BinarySearch(numbers, 5));
        }

        [TestMethod]
        public void HugeArray()
        {
            int[] hugeNumbers = new int[100001];
            for(int i=0;i<hugeNumbers.Length;i++)
            {
                hugeNumbers[i] = i;
            }
            Assert.AreEqual(5, Program.BinarySearch(hugeNumbers, 5));
        }

        [TestMethod]
        public void FiveArray()
        {
            int[] fiveNumbers = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(2, Program.BinarySearch(fiveNumbers, 3));
        }

        [TestMethod]
        public void DublicateElement()
        {
            int[] fiveNumbers = new int[] {1, 1, 1, 1, 2 };
            Assert.AreEqual(2, Program.BinarySearch(fiveNumbers, 1));
        }
    }
}