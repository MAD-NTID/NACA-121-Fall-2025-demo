
const double COMMISSON_RATE = 0.07;
const int MINIMUM_COMMISION_PRICE = 10000;

Console.Write("Enter the car value:$ ");
double amount = double.Parse(Console.ReadLine());


//:C for currency
//:F2 --> F is for floating point, 2 is for 2 decimal place
Console.WriteLine($"Price is:{amount:C}");

//long way
if (amount >= MINIMUM_COMMISION_PRICE)
{
    double commission = amount * COMMISSON_RATE;
    Console.WriteLine($"Commission amount: {commission:C}");
}
else
{
    double commission = 0;
    Console.WriteLine($"Commission amount: {commission:C}");
}

//can be short
// double commission = 0; // start with comission at 0
// if (amount >= MINIMUM_COMMISION_PRICE)
// {
//     commission = amount * COMMISSON_RATE;

// }
// Console.WriteLine($"Commission amount: {commission:C}");