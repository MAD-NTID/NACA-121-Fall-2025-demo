// CoolClass cool = new CoolClass();
int length = 5;
// Square square = new Square(length);
IShape square = new Square(length);
// square.CalculateArea();

// Console.WriteLine($"The area of the square is: {square.Area}");
PrintShapeInformation(square);

length = 5;
int width = 4;
IShape rectangle = new Rectangle(length, width);
// rectangle.CalculateArea();

// Console.WriteLine($"The area of the rectangle is: {rectangle.Area}");
PrintShapeInformation(rectangle);

void PrintShapeInformation(IShape shape)
{
    Console.WriteLine($"The type of shape is:{shape}");
    shape.CalculateArea();
    Console.WriteLine($"The area of the {shape} is: {shape.Area}");
}