
//a method to take two numbers, add them and return the sum
int Sum(int num1, int num2)
{
    return num1 + num2;
}

//the parameter message is optional
//if no parameter is supply, it will default to NACA-120
void Print(string message = "NACA 120")
{
    Console.WriteLine(message);
    //return; --> you can also do this if you want

}


//calculate the total, assign it to a variable called total
int total = Sum(5, 5);
Console.WriteLine(total);

Print("Hello world");
Print();