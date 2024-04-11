namespace TDD.Tests;

public class StringCalcTests
{
    private StringCalc calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new StringCalc();
    }

    [Test]
    public void TestSimpleNumbers()
    {
        Assert.That(calculator.Add("1"), Is.EqualTo(1));
    }
}