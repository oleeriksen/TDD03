using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLibrary;

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
        [DataRow(new int[] { 1,2,1}, false)]
        [DataTestMethod]
        public void TC(int[] a, bool b)
        {
            ArrayFunctions af = new ArrayFunctions();
            Assert.IsTrue(af.IsUnique(a) == b);
        }
    }
}
