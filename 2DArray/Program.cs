// Create a 2d Numbers Array without values for adding later
NumbersArray numbersArray = new(2, 3);

numbersArray.AddNumberToRowCol(0, 0, 5);
numbersArray.AddNumberToRowCol(0, 1, 10);
numbersArray.AddNumberToRowCol(0, 2, 15);

numbersArray.AddNumberToRowCol(1, 0, 20);
numbersArray.AddNumberToRowCol(1, 1, 25);
numbersArray.AddNumberToRowCol(1, 2, 30);

Console.WriteLine("NumbersArray 1 - ");
// Print out all the values
for (int r = 0; r < numbersArray.Rows; r++)
{
    Console.Write($"Row {r} - ");

    for (int c = 0; c < numbersArray.Cols; c++)
    {
        Console.Write($"{numbersArray.GetNumberFromRowCol(r, c)}        ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nNumbersArray 2 - ");
NumbersArray2 numbersArray2 = new();

// Print out all the values
for (int r = 0; r < numbersArray2.GetRows(); r++)
{
    Console.Write($"Row {r} - ");

    for (int c = 0; c < numbersArray2.GetCols(); c++)
    {
        Console.Write($"{numbersArray2.GetNumberFromRowCol(r, c)}        ");
    }

    Console.WriteLine();
}