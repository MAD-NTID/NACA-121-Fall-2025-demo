public class Elephant : Animal
{

    public Elephant(string name, int age) : base(name, age)
    {

    }

    public override string Sound()
    {
        return "trumpet";
    }

    public override string Travel()
    {
        return "stomp stomp";
    }

    public override string ToString()
    {
        return $"Type:{GetType().Name}\t" + base.ToString();
    }
}