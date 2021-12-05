using System;
using Xunit;

namespace DebUnitTest
{
    public class DebUnitTest1
    {
        [Fact]
        public void PassingTest()
        {
	    Assert.Equal(7, Add(5, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(11, Add(7, 4));
        }

	int Add(int x, int y)
	{
	    return x + y;
	}

	[Theory]
	[InlineData(3)]
	[InlineData(5)]
	[InlineData(7)]
	public void Theory(int value)
	{
	    Assert.True(IsOdd(value));
	}

	bool IsOdd(int value)
	{
	    return value % 2 == 1;
	}
    }
}
