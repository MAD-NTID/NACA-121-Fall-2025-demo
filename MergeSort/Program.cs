int[] numbers = { 42, 7, 19, 88, 3, 56, 11, 90, 24, 6, 77, 15, 31, 62, 5 };
MergeSort<int> mergeSort = new MergeSort<int>();

Console.WriteLine("Unsorted values:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
Console.WriteLine("Sorting the array");
numbers = mergeSort.Sort(numbers);

Console.WriteLine("sorted values:");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
