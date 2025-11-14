// HelpMe<int> help = new HelpMe<int>();


// int x = 6;
// int y = 4;

// Console.WriteLine(help.Compare(x,y));
// Console.WriteLine(help.Greater(x,y));


int[] numbers = { 42, 7, 19, 88, 3, 56, 11, 90, 24, 6, 77, 15, 31, 62, 5 };
InsertionSort<int> insertionSort = new InsertionSort<int>();

Console.WriteLine("Unsorted values:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
Console.WriteLine("Sorting the array");
insertionSort.Sort(numbers);

Console.WriteLine("sorted values:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();


