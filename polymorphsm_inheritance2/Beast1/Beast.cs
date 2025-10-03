public class Beast : IBeast
{
    protected string name;
    public string Name
    {
        get { return name; }
        private set
        {
            name = value;
        }
    }
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }
    public int AttackPower { get; private set; }

    public Beast(string name, int maxHelath, int attackPower)
    {
        this.Name = name;
        this.MaxHealth = maxHelath;
        this.AttackPower = attackPower;
    }
    public virtual int Attack()
    {
        Random random = new Random();
        int attack = random.Next(15, 21);
        attack = (int)((1.0 + attack) / 100);
        return AttackPower * attack;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;

    }
    
    public override bool Equals(object? obj)
    {
        //if 2 classes are not the same then they are different
        if (obj is not Beast)
        {
            return false;
        }

        Beast beast = (Beast)obj;

        return this.Name == beast.Name && this.CurrentHealth == beast.CurrentHealth
               && this.MaxHealth == beast.MaxHealth && this.AttackPower == beast.AttackPower;
    }
}