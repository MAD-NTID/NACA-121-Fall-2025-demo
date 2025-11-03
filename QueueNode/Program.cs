Queue<string> numbers = new Queue<string>();
numbers.Enqueue("one");
numbers.Enqueue("two");
numbers.Enqueue("three");
numbers.Enqueue("four");
numbers.Enqueue("five");

Console.WriteLine($"Peeking at the front..data is:{numbers.Peek()}");

Console.WriteLine(numbers);
Console.WriteLine($"Hava two?{numbers.Contains("two")}");
Console.WriteLine($"Hava seven?{numbers.Contains("seven")}");

Console.WriteLine("Converting to array");
string[] elements = numbers.ToArray();

foreach (string element in elements)
{
    Console.WriteLine(element);
}

Console.WriteLine("Foreach queue");
foreach(string element in numbers)
{
    Console.WriteLine(element);
}

for (int i = 0; i < 5; i++)
    Console.WriteLine($"Dequeue from queue: {numbers.Dequeue()}");
Console.WriteLine(numbers);


