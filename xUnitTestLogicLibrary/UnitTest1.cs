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
        public void TC(int[] input, bool expectedResult)
        {
            ArrayFunctions af = new ArrayFunctions();
            bool actualResult = af.IsUnique(input);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestNullException()
        {
            ArrayFunctions af = new ArrayFunctions();

            Assert.Throws<ArgumentNullException>(() => af.IsUnique(null));
        }

        [Theory]
        [InlineData(12, false)]
        [InlineData(13, true)]
        [InlineData(14, true)]
        [InlineData(18, true)]
        [InlineData(19, true)]
        [InlineData(20, false)]
        public void TestTeenager(int input, bool expectedResult)
        {
            ArrayFunctions af = new ArrayFunctions();
            bool actualResult = af.IsTeenager(input);
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
