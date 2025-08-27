double max = 2147483647;

//add 1 to max --> this will become negative because of overflow
max = max + 1;

Console.WriteLine(max);

//character
char letter = 'A';
//letter = 'AB'; --> Error, too many characters

const int DAYS_IN_THE_WEEK = 7;
//DAYS_IN_THE_WEEK = 5; --> Error, you cant change something 
//once you use "const" keyword

string name = "Kemoy";
int age = 5;

//try "accident" put number in name variable
//name = 6; --> Error, cant mix types.. You can only assign the same time

//c# will force anything that you put in CW to automatically become a string
Console.WriteLine("Hello " + name + " You are " + age);


