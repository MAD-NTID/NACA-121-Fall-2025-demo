// int count = 1;

// Console.WriteLine("\n While loop");
// //we will repeat this 10 times
// while (count <= 10)
// {
//     //display the count
//     Console.WriteLine($"Counter:{count}");
//     count++;
// }


// //for loop example
// Console.WriteLine("\n For loop");
// for (count = 1; count <= 10; count++)
// {
//     Console.WriteLine($"Counter:{count}");
// }

// //Continue until the user decided to quit
// bool repeat = true;
// Random random = new Random();
// while (repeat)
// {
//     int secretNumber = random.Next(1, 6); //add 1 to include the 5
//     Console.WriteLine("Enter a number between 1-5:");
//     int pick = int.Parse(Console.ReadLine());

//     //did the user successfully guessed the number?
//     if (pick == secretNumber)
//     {
//         Console.WriteLine("Yay! You got it!");
//     }

//     //if the user get it wrong, show the secret number
//     else
//     {
//         Console.WriteLine($"The secret number was {secretNumber}");
//     }

//     //ask if they want to go again, if no... set repeat to false
//     Console.Write("Do you want to try again?:");
//     if (Console.ReadLine().ToLower() == "no")
//     {
//         repeat = false;
//     }

// }

// //using break example
// while (true)
// {
//     int secretNumber = random.Next(1, 6); //add 1 to include the 5
//     Console.WriteLine("Enter a number between 1-5:");
//     int pick = int.Parse(Console.ReadLine());

//     //did the user successfully guessed the number?
//     if (pick == secretNumber)
//     {
//         Console.WriteLine("Yay! You got it!");
//     }

//     //if the user get it wrong, show the secret number
//     else
//     {
//         Console.WriteLine($"The secret number was {secretNumber}");
//     }

//     //ask if they want to go again, if no... set repeat to false
//     Console.Write("Do you want to try again?:");
//     if (Console.ReadLine().ToLower() == "no")
//     {
//         break;
//     }

// }

// //using break example
// while (true)
// {
//     int secretNumber = random.Next(1, 6); //add 1 to include the 5
//     Console.WriteLine("Enter a number between 1-5:");
//     int pick = int.Parse(Console.ReadLine());

//     //check to make sure 1-5
//     if (pick > 5 || pick < 1)
//     {
//         Console.WriteLine("You must pick between 1-5");
//         Console.WriteLine("Do not test me you filthy human!");
//         continue;
//     }

//     //did the user successfully guessed the number?
//     if (pick == secretNumber)
//     {
//         Console.WriteLine("Yay! You got it!");
//     }

//     //if the user get it wrong, show the secret number
//     else
//     {
//         Console.WriteLine($"The secret number was {secretNumber}");
//     }

//     //ask if they want to go again, if no... set repeat to false
//     Console.Write("Do you want to try again?:");
//     if (Console.ReadLine().ToLower() == "no")
//     {
//         break;
//     }

// }

bool isHomeworkDone = false;

//do while will do first then check later
//aka party first then check and accept the consequences

// do
// {
//     Console.WriteLine("Partying so hard!!! - DoWhile");
// } while (isHomeworkDone==true);

// //check first before partying
// while (isHomeworkDone)
// {
//     Console.WriteLine("Partying so hard!!! While");
// }

bool exit = false;
do
{
    Console.Write("Enter a number:");
    Console.WriteLine($"You typed: {Console.ReadLine()}");

    Console.Write("Do you want to enter another number?:");
    if (Console.ReadLine().ToLower() == "no")
    {
        exit = true;
    }
} while (!exit);

