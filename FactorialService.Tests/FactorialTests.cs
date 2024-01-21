namespace FactorialService.Tests;

public class FactorialTests
{
    [Fact]
    public void Factorial_ValueOf1()
    {
        Assert.Equal(1, FactorialLogic.GetFactorialValue(1));
    }

    [Fact]
    public void Factorial_Value10()
    {
        Assert.Equal(120, FactorialLogic.GetFactorialValue(5));
    }

    [Fact]
    public void Factorial_Failure()
    {
        Assert.Equal(1, FactorialLogic.GetFactorialValue(-1));
    }
}