using System;
using LogicLibrary;
using Xunit;

namespace xUnitTestLogicLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 2, 3, 4 };

            Assert.True(af.IsUnique(a));
            Assert.True(af.IsUnique(new int[0]));
        }

        [Fact]
        public void TestDuplicates()
        {
            ArrayFunctions af = new ArrayFunctions();

            int[] a = { 1, 2, 3, 4, 4 };

            Assert.False(af.IsUnique(a));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, true)]
        [InlineData(new int[] { 1, 2, 1 }, false)]
        public void TC(int[] a, bool b)
        {
            ArrayFunctions af = new ArrayFunctions();
            Assert.True(af.IsUnique(a) == b);
        }

        [Fact]
        public void TestNullException()
        {
            ArrayFunctions af = new ArrayFunctions();

            Assert.Throws<ArgumentNullException>(() => af.IsUnique(null));
        }
    }
}
