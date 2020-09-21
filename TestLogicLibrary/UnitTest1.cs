using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLibrary;
using System;

namespace TestLogicLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTrue()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 2, 3, 4 };

            Assert.IsTrue(af.IsUnique(a));
            Assert.IsTrue(af.IsUnique(new int[0]));
        }

        [TestMethod]
        public void TestDuplicates()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 1, 2, 3, 4, 4 };

            Assert.IsFalse(af.IsUnique(a));
        }

        [DataRow(new int[] { 1, 2, 3 }, true)]
        [DataRow(new int[] { 1, 2, 1 }, false)]
        [DataRow(new int[] { }, true)]
        [DataTestMethod]
        public void TC(int[] input, bool expectedResult)
        {
            ArrayFunctions af = new ArrayFunctions();
            bool actualResult = af.IsUnique(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestNullException() {
            ArrayFunctions af = new ArrayFunctions();

            Assert.ThrowsException<ArgumentNullException>(() => af.IsUnique(null));
            }
    }
}
