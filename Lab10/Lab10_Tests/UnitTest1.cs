using Lab10;
using Xunit;

namespace Lab10_Tests;

public class Tests
{
    private readonly Calculator _calc = new Calculator();

    [Fact]
    public void TestAdd()
    {
        double result = _calc.AddNumbers(3, 5);

        //Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void TestAddNegativeNumbers()
    {
        double result = _calc.AddNumbers(-3, -5);

        //Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void TestSubtract()
    {
        double result = _calc.SubtractNumbers(10, 3);

        //Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void TestSubtractNegativeResult()
    {
        double result = _calc.SubtractNumbers(3, 10);

        //Assert
        Assert.Equal(-7, result);
    }

    [Fact]
    public void TestMultiply()
    {
        double result = _calc.MultiplyNumbers(4, 5);

        //Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void TestMultiplyByZero()
    {
        double result = _calc.MultiplyNumbers(5, 0);

        //Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void TestMultiplyNegativeNumbers()
    {
        double result = _calc.MultiplyNumbers(-4, 5);

        //Assert
        Assert.Equal(-20, result);
    }

    [Fact]
    public void TestDivide()
    {
        double result = _calc.DivideNumbers(20, 4);

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void TestDivideWithRemainder()
    {
        double result = _calc.DivideNumbers(10, 3);

        //Assert
        Assert.Equal(3, result); // Integer division
    }

    [Fact]
    public void TestDivideNegativeNumbers()
    {
        double result = _calc.DivideNumbers(-20, 4);

        //Assert
        Assert.Equal(-5, result);
    }

    [Fact]
    public void TestDivideByZero()
    {
        // Assert that dividing by zero throws an exception
        Assert.Throws<DivideByZeroException>(() => _calc.DivideNumbers(10, 0));
    }
}