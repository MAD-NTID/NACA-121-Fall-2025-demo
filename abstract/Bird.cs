public class Bird : Animal
{

    public Bird(string name, int age) : base(name, age)
    {

    }

    public override string Sound()
    {
        return "tweet tweet";
    }

    public override string Travel()
    {
        return "fly";
    }

    public override string ToString()
    {
        return $"Type:{GetType().Name}\t" + base.ToString();
    }
}