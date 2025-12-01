// F+ square = (int x)=> x *x;
var square = (int x) => x*x;

var loopy = (int x)=>
{
    for(int i = 1; i < 10; i++)
    {
        x*=i;
    }

    return x;
};


int Square(int x)
{
    return x * x;
}

Console.WriteLine(square(2));
Console.WriteLine(Square(2));
Console.WriteLine(loopy(2));

var printHelloWorld = ()=> Console.WriteLine("Hello world!!!");

printHelloWorld();

Action<string> printHelloUserName = (string name)=> Console.WriteLine($"Hello {name}");

var printMultipleStatement = () =>
{
    Console.WriteLine("Hello");
    Console.WriteLine("World");
    Console.WriteLine("The semester is almost over!!!");
};

printHelloUserName("Nai");
printHelloUserName("Amber");
printHelloUserName("Groot");

printMultipleStatement();