Console.WriteLine("Enter the number for days of the week(1-7):");
int day = int.Parse(Console.ReadLine());

//switch between each days 1-7
switch (day)
{
    //day is 1
    case 1:
        Console.WriteLine("Today is sunday");
        break;
    case 2:
        Console.WriteLine("Today is Monday");
        break;
    default:
        Console.WriteLine("Invalid day!");
        break;
}
