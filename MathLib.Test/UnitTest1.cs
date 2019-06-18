using System;
using MathLib;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          Assert.Equal(4, MyMath.Sum(2,2));
        }
    }
}
