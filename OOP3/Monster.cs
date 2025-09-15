public class Monster
{
    private string name;
    private double distance;
    private int health;

    public string Name
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }

    public int Health
    {
        set
        {
            health = value;
        }
        get
        {
            return health;
        }
    }

    public double Distance
    {
        set
        {
            distance = value;
        }
        get
        {
            return distance;
        }
    }

    public Monster()
    {
        Distance = 0;
        Name = "N/A";
        Health = 0;
    }

    public Monster(string name, int health, double distance)
    {
        Distance = distance;
        Name = name;
        Health = health;
    }

    public void TakeDamage()
    {
        Console.WriteLine("Got punched!!! Losing 5 health point");
        int loss = 5;
        Health -= loss;
    }

    public void TakeDamage(int damageAmount)
    {
        Console.WriteLine("passing specific damage point");
        Health -= damageAmount;
    }

    public void TakeDamage(string attackName, int damageAmount)
    {
        Console.WriteLine($"Attacking with {attackName} and damage point: {damageAmount}");
        Health -= damageAmount;
    }

    public double TakeDamage(double fractionDamage)
    {
        Console.WriteLine("Attacking with fraction damage");
        return 0.0; //just for example
    }

    //change the behavior of the ToString() to return all attribute information
    public override string ToString()
    {
        return $"Name:{name}\tHealth:{health}\tDistance:{distance}";
    }




}