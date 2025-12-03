List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};

int evenOnly = numbers.Count(num=> num % 2 ==0);
Console.WriteLine(evenOnly);

// List<int> evenNumbers = new List<int>();
// foreach(int number in numbers)
// {
//     if(number % 2 == 0)
//     {
//         evenNumbers.Add(number);
//     }
// }

// Console.WriteLine($"Total even numbers:{evenNumbers.Count}");

List<string> names = new List<string>{"Alice", "Black Mamba", "Robert","Lebron", "Michael Jordan"};

var nameLength = names.Select(name=> new {Name=name, TotalNameLength=name.Length});

//show the items in the new nameLength
foreach(var item in nameLength)
{
    Console.WriteLine(item);
    Console.WriteLine(item.Name);
    Console.WriteLine(item.TotalNameLength);
}

var person = new []
{
    new {Name="Agent M", Age=50},
    new {Name="Agent Q", Age=25},
    new {Name="Agent T", Age=20},
};

var agentsInFiveYears = person.Select(agent=> new {Name=agent.Name, AgeInFiveYears=agent.Age + 5});

Console.WriteLine("Agents ages in 5 years:");
foreach(var agent in agentsInFiveYears)
{
    Console.WriteLine(agent);
}

//where example
var twentyFiveAndAboveAgents = person.Where(agent=> agent.Age>=25);

Console.WriteLine("\nAgents who are 25 and above:\n");
foreach(var agent in twentyFiveAndAboveAgents)
{
    Console.WriteLine(agent);
}