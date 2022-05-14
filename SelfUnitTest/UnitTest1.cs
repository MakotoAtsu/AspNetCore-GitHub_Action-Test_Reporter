using System;
using Xunit;

namespace SelfUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 1;
            var b = 2;
            Assert.Equal(3, a + b);
        }

        [Fact]
        public void Test2()
        {
            var c = 15;
            Assert.True(c > 10);
        }

        [Fact]
        public void Test3()
        {
            Action action = () => throw new Exception();

            Assert.Throws<Exception>(action);
        }

        [Fact]
        public void Test4()
        {
            var a = 3;
            var b = 10;

            Assert.Equal(30, a * b);
        }
    }
}
