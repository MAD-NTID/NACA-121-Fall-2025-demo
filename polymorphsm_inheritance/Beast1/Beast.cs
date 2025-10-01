public class Beast : IBeast
{
    public string Name { get; private set; }
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }
    public int AttackPower { get; private set; }

    public Beast(string name, int maxHelath, int attackPower)
    {
        this.Name = name;
        this.MaxHealth = maxHelath;
        this.AttackPower = attackPower;
    }
    public int Attack()
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
}