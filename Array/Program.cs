//Setup array type, name and size
// int[] numbers = new int[20]; //max 20 element

// //print all numbers default
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine($"{i}:{numbers[i]}");
// }

// //add the value 5 to positon 0
// numbers[0] = 5;
// //add the value 7 to position 9
// numbers[9] = 7;

// //print all numbers after update
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine($"{i}:{numbers[i]}");
// }

// //use a loop to random add numbers to each elements
// Random random = new Random();

// for (int i = 0; i < numbers.Length; i++)
// {
//     //random pick a number between 1-100;
//     int pick = random.Next(1, 101);
//     numbers[i] = pick;
// }

// //print all numbers after update
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine($"{i}:{numbers[i]}");
// }

// //approach #1
// int lastNumber = numbers[19]; // the last number
// Console.WriteLine($"The last number is:{lastNumber}");

// //approach #2
// int index = numbers.Length;
// Console.WriteLine("The index is:::::: " + index + "...FACEPALM");
// lastNumber = numbers[numbers.Length-1];
// Console.WriteLine($"The last number is:{lastNumber}");


string[] names;
//get the size from the user
Console.Write("How many student do you want to add:");
int size = int.Parse(Console.ReadLine());

//add the size to the array
names = new string[size];

//prompt the user for the names based on size
for (int i = 0; i < size; i++)
{
    Console.Write($"Enter the name of student {i + 1}: ");
    //get the name
    string name = Console.ReadLine();
    //add the name to the right position in the array
    names[i] = name;

    //inform the user that the name was added
    Console.WriteLine($"{name} was successfully added!\n");
}

//show list
Console.WriteLine();//space
Console.WriteLine("The list of students");
//approach 1
// for (int i = 0; i < names.Length; i++)
//     Console.WriteLine($"Student {i + 1}: {names[i]}");

//approach2
printName(names);

//C# WAY OF MAKING METHOD
void printName(string[] names)
{
    for (int i = 0; i < names.Length; i++)
    Console.WriteLine($"Student {i + 1}: {names[i]}");
}

//PYTHON WAY OF MAKING METHOD
// def printName(names):
//    for name in names:
//         print(name)



