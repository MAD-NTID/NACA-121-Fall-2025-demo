public interface IPet
{
    public string Name { get; }
    public int Age{ get; }
    public void Adopt(string name);
    public void Birthday();
}