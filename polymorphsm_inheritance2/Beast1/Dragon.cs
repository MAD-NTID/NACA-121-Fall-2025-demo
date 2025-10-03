public class Dragon : Beast
{
    public Dragon(string name, int maxHelath, int attackPower) : base(name, maxHelath, attackPower)
    {
        this.name = name;
    }

    public override int Attack()
    {
        Console.WriteLine("Attacking with fire breathing!!!");
        int extraDamage = 20;

        return base.Attack() + extraDamage;
    }

    public int FlyAttack()
    {
        return 3000;
    }

    public override bool Equals(object? obj)
    {
        //if 2 classes are not the same then they are different
        if (obj is not Dragon)
        {
            return false;
        }

        return base.Equals(obj);
    }
}