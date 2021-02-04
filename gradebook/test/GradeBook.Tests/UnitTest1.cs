using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 5;
            int y = 2;
            int expected = 10;
            int actual = x * y;
            Assert.Equal(expected, actual);
        }
    }
}
