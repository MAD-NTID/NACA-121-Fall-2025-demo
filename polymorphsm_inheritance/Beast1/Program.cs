Beast godzilla = new Beast("Godzilla", 10, 2000);
int godzillaAttack = godzilla.Attack();



Beast dragon = new Beast("Dragon", 500, 1400);
int dragonAttack = dragon.Attack();

//dragon damage
dragon.TakeDamage(godzillaAttack);

godzilla.TakeDamage(dragonAttack);
Console.WriteLine($"{godzilla} spikes the {dragon}'s damage {godzilla}");



