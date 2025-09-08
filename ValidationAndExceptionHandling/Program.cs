//Validation example
// while (true)
// {
//     Console.Write("Enter a number:");

//     string newData = Console.ReadLine();

//     //check if it is a numeric string before converting
//     //approach 1
//     // if (!newData.All(char.IsDigit))
//     // {
//     //     Console.WriteLine("Enter a number!");
//     //     continue;

//     // }
//     //int inputValue = int.Parse(newData);

//     //approach 2 with try parse
//     // bool isDigit = int.TryParse(newData, out int inputValue);
//     // if (!isDigit)
//     // {
//     //     Console.WriteLine("Enter a number!");
//     //     continue;
//     // }

//     //approach #3
//     if (!int.TryParse(newData, out int inputValue))
//     {
//         Console.WriteLine("Enter a number!");
//         continue;
//     }

//     Console.WriteLine($"The value is {inputValue}");
// }

//Exception handling example
while (true)
{
    Console.WriteLine("Exception handling example\n============================");
    Console.Write("Enter a number:");

    string newData = Console.ReadLine();

    try
    {
        //normal mode
        int inputValue = int.Parse(newData);
        Console.WriteLine($"The value is {inputValue}");
    }
    catch
    {
        //show this instead of crash
        Console.WriteLine("Enter a number!");
    }

}


