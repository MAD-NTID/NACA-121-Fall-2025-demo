﻿int[] numbers = { 42, 7, 19, 88, 3, 56, 11, 90, 24, 6, 77, 15, 31, 62, 5 };
QuickSort<int> QuickSort = new QuickSort<int>();

Console.WriteLine("Unsorted values:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
Console.WriteLine("Sorting the array");
QuickSort.Sort(numbers, 0, numbers.Length-1);

Console.WriteLine("sorted values:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();

QuickSort.Sort(numbers, 0, numbers.Length-1, true);

Console.WriteLine("sorted values descending:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}