using NUnit.Framework.Legacy;

namespace Test;

public class Tests
{
    private CoolClass cool;

    //the setup is use by every [Test] and each
    //get a FRESH setup
    [SetUp]
    public void Setup()
    {
        this.cool = new CoolClass();
    }

    [Test]
    //you must always add [Test]
    //Test naming standard Test<NameMethod>
    public void TestSayHello()
    {
        //setup
        string expected = "Hello";

        //invoke

        string actual = cool.SayHello();

        //Assert
        // ClassicAssert.AreEqual(actual, expected);
        //or
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestSayHelloName()
    {
        //setup
        string name = "Kemoy"; //parameter to pass to method
        string expected = "Hello Kemoy";//what I want to see when method invoke

        //invoke
        string actual = cool.SayHello(name);

        //Analyze
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestSquareArea()
    {
        //setup
        int length = 5;
        double expected = 25;

        //invoke
        Square square = new Square(length);
        square.CalculateArea();

        double actual = square.Area;

        //analyze
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void TestRectangleArea()
    {
        int length = 5;
        int width = 4;
        double expected = 20;

        //invoke
        Rectangle rectangle = new Rectangle(length, width);
        rectangle.CalculateArea();
        double actual = rectangle.Area;

        //analyze
        Assert.That(actual, Is.EqualTo(expected));
    }
}
