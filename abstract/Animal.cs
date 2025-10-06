public abstract class Animal : IAnimal
{
    private string name;
    private int age;
    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                value = "N/A";
            }
            name = value;
        }
    }



    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 0)
            {
                value = 0;
            }
            age = value;
        }
    }

    public Animal(string name, int age)
    {
        Age = age;
        Name = name;
    }

    public void CelebrateBirthday()
    {
        age++;
    }

    public abstract string Sound();


    public abstract string Travel();

    public override string ToString()
    {
        return $"Name:{Name}\tAge:{Age}";
    }
}