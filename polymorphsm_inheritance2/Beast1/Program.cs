Beast godzilla = new Godzilla("Godzilla", 10, 2000);
Beast godzill2 = new Godzilla("Godzilla", 10, 2000);

Console.WriteLine("Check if both same:");
Console.WriteLine(godzill2.Equals(godzilla));

int godzillaAttack = godzilla.Attack();
int deathRoll = 0;
if (godzilla is Godzilla)
{
    deathRoll = ((Godzilla)godzilla).DeathRollAttack();
}




Beast dragon = new Dragon("Dragon", 500, 1400);
int dragonAttack = dragon.Attack();

//check if is type of dragon
int flyAttack = 0;
if (dragon is Dragon)
{
    Dragon dragon1 = (Dragon)dragon;
    flyAttack = dragon1.FlyAttack();
}



//dragon damage
dragon.TakeDamage(godzillaAttack);

godzilla.TakeDamage(dragonAttack);
Console.WriteLine($"{godzilla} spikes the {dragon}'s damage {godzilla}");



