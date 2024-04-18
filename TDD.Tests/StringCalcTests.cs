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
        Assert.That(calculator.Add("1,4"), Is.EqualTo(5));
        Assert.That(calculator.Add(""), Is.EqualTo(0));
        Assert.That(calculator.Add("3,16,200,5"), Is.EqualTo(222));
    }

     [TestCase("1001,1",1)]
     [TestCase("101",100)]
     [TestCase("100",99)]
     [TestCase("99",99)]
     [TestCase("1000",990)]
    public void TestOppgave2( string input, int answer)
    {
        Assert.That(calculator.Add(input), Is.EqualTo(answer));
    }    
    
    [Test]
    public void TestOtherSeparators()
    {
        Assert.That(calculator.Add("//;\n1;3"), Is.EqualTo(4));
    }

    [Test]
    public void TestUtropsTegnBetalerIkkeSkatt()
    {
        Assert.That(calculator.Add("1;!999!"), Is.EqualTo(1000));
    }

}