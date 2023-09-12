using Xunit;

namespace MyProject.Tests;

public class AdderTests
{
    [Theory]
    [InlineData(-1, -1)]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    public void Add_ZeroAdditiveNumber_ReturnsSameNumber(int number, int expected)
    {
        Adder adder = new(0);

        int actual = adder.Add(number);

        Assert.Equal(expected, actual);
    }
}
