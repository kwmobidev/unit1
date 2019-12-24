using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void WhenAddingTwoNumbersThenSumIsCorrect()
        {
            var sum = 7 + 9;
            Assert.Equal(16, sum);
        }

    }
}
