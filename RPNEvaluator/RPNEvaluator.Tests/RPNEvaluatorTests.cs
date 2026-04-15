using Xunit;
using RPNEvaluator;

namespace RPNEvaluator.Tests;

public class RPNEValuatorTests
{
    // [Fact] = a single, fixed test
    [Fact]
    public void TestOnePlusOne()
    {
        var result = RPNEvaluator.Evaluate("1 1 +", null);
        Assert.Equal(2, result);
    }

    // [Theory] = multiple tests with parameters
    [Theory]
    [InlineData("0 1 *", 0)]
    [InlineData("1 1 -", 0)]
    [InlineData("1 2 /", 0)]
    public void TestFormula(string formula, int expected)
    {
        var result = RPNEvaluator.Evaluate(formula, null);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void WithDict()
    {
        var result = RPNEvaluator.Evaluate("x y +", new Dictionary<string, int> { { "x", 1}, { "y", 1} });
        Assert.Equal(2, result);
    }


    //Evaluate with float with float input
    [Fact]
    public void TestOnePlusOneFloat()
    {
        var result = RPNEvaluator.Evaluatef("1 1 +", new Dictionary<string, float>());
        Assert.Equal(2.0, result);
    }

    [Fact]
    public void DivisionFloat()
    {
        var result = RPNEvaluator.Evaluatef("1 2 /", new Dictionary<string, float>());
        Assert.Equal(0.5, result);
    }

    [Theory]
    [InlineData("4 3 %", 1.0)]
    //[InlineData("9 12 *", 108.0)]
    //[InlineData("25 5 /", 5.0)]

    public void TestFormulaFloatVariant(string formula, float expected)
    {
        var result = RPNEvaluator.Evaluatef(formula, new Dictionary<string, float>());
        Assert.Equal(expected, result);
    }

    [Fact]
    public void WithDictFloat()
    {
        var result = RPNEvaluator.Evaluatef("x y /", new Dictionary<string, float> { { "x", 25 }, { "y", 5 } });
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void WithDiv()
    {
        var result = RPNEvaluator.Evaluatef("x y *", new Dictionary<string, float> { { "x", 9 }, { "y", 12 } });
        Assert.Equal(108.0, result);
    }

    //Float with int input for the dict
}

