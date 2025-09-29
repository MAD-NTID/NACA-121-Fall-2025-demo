public class CoolClass
{
    //This is a simple method in cool class that
    //say "Hello"
    public string SayHello()
    {
        return "Hello";
    }

    //This method takes a name and say Hello <name>
    public string SayHello(string name)
    {
        return $"Hello {name}";
    }
        public string SayHello(string name, string country)
    {
        return $"Hello {name}. You are from  {country}";
    }
}