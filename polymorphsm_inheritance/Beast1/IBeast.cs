public interface IBeast
{
    public string Name{get;}
    public int MaxHealth{get;}
    public int CurrentHealth{get;}
    public int AttackPower{get;}
    public void TakeDamage(int damage);
    public int Attack();
}
   
   