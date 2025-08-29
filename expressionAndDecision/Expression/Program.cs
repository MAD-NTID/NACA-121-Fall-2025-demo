//COMPOUND EXAMPLE

int x = 5;

//update x
// x = x + 1;
x += 1;

//subtract
x -= 1;
// x -= 1;
// x -= 1;

Console.WriteLine($"The value of X is:{x}");

//prefix and postfix

int y = 20,z = 0, p = 0;

//first increase y by 1 then assign the new value to p
p = ++y;
Console.WriteLine($"P is :{p}");

//first increase p by 1 then assign the new value to p
p = ++p;

//first assign the current value of p to z then increase p by 1
//z should have the old p value and p have a new value + 1
z = p++;
Console.WriteLine($"P now is :{p}");
Console.WriteLine($"Z  is :{z}");