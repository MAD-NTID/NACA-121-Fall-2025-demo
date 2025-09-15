Monster kong = new Monster("Nai", 100, 0);
Monster godzilla = new Monster("Amber", 90, 0);

Console.WriteLine("Amber punch Nai");
kong.TakeDamage();

Console.WriteLine($"Nai health:{kong.Health}");

Console.WriteLine("Amber chokehold Nai");
kong.TakeDamage(15);
Console.WriteLine($"Nai health:{kong.Health}");

Console.WriteLine("\nNai finally unleash her revenge!");
string attackName = "Lightening super shock revenge!";
int damage = 35;
godzilla.TakeDamage(attackName, damage);
Console.WriteLine($"Amber health:{godzilla.Health}");

Console.Write("The result for ToString is: ");
Console.WriteLine(godzilla);





