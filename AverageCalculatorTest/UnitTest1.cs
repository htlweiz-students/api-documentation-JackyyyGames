using lib00;
using System;
using Xunit;

namespace AverageCalculatorTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var Calculator = new AverageCalculator();
        Calculator.add(3.5);
        double[] arrayafter = { 3.5 };
        double[] arrayfromtest = Calculator.getElements();
        Assert.Equal(arrayafter, arrayfromtest);
    }

    [Fact]
    public void Test2()
    {
        var Calculator = new AverageCalculator();
        Calculator.add(4.5);
        double[] arrayafter = { 4.5 };
        double[] arrayfromtest = Calculator.getElements();
        Assert.Equal(arrayafter, arrayfromtest);
    }
    [Fact]
    public void Test3()
    {
        var calculator = new AverageCalculator();
        calculator.add(1.0);
        Assert.Equal(1, calculator.count());
    }

    [Fact]
    public void Test4()
    {
        var calculator = new AverageCalculator();
        calculator.add(1.0);
        calculator.add(2.0);
        calculator.add(3.0);
        Assert.Equal(3, calculator.count());
    }

    [Fact]
    public void Test5()
    {
        var calculator = new AverageCalculator();
        double[] values = { 1.0, 2.0, 3.0 };
        calculator.add(values);
        Assert.Equal(values, calculator.getElements());
    }

    [Fact]
    public void Test6()
    {
        var calculator = new AverageCalculator();
        calculator.add(2.0);
        calculator.add(4.0);
        calculator.add(6.0);
        Assert.Equal(4.0, calculator.getAverage());
    }

    [Fact]
    public void Test7()
    {
        var calculator = new AverageCalculator();
        calculator.add(-2.0);
        calculator.add(2.0);
        Assert.Equal(0.0, calculator.getAverage());
    }
    [Fact]
    public void Test8()
    {
        var calculator = new AverageCalculator();
        Assert.Equal(0, calculator.count());
        Assert.Empty(calculator.getElements());
    }

    [Fact]
    public void Test9()
    {
        var calculator = new AverageCalculator();
        calculator.add(0.0);
        calculator.add(0.0);
        Assert.Equal(0.0, calculator.getAverage());
    }

    [Fact]
    public void Test10()
    {
        var calculator = new AverageCalculator();
        calculator.add(double.MaxValue);
        calculator.add(double.MaxValue);
        Assert.True(double.IsInfinity(calculator.getAverage()));
    }
}
