public class Godzilla : Beast
{
    public Godzilla(string name, int maxHelath, int attackPower) : base(name, maxHelath, attackPower)
    {

    }

    public override int Attack()
    {
        Console.WriteLine("Attacking Spike whipping!!!");
        int extraDamage = 50;

        return base.Attack() * extraDamage;
    }

    public int DeathRollAttack()
    {
        return 5000;
    }

       public override bool Equals(object? obj)
    {
        //if 2 classes are not the same then they are different
        if (obj is not Godzilla)
        {
            return false;
        }

        return base.Equals(obj);
    }
}