public interface IAnimal
{
    public string Name { get; }
    public int Age { get; }



    public abstract string Sound();
    public abstract string Travel();

    public void CelebrateBirthday();


}