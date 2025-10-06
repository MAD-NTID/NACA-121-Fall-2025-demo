// Animal animal = new Elephant("Kemoy", 5);
// IAnimal bird = new Bird("Nai", 10);

IAnimal[] animals = {
    new Elephant("Kemoy", 5),
    new Bird("Nai", 10)
};

for (int i = 0; i < animals.Length; i++)
{
    IAnimal animal = animals[i];
    if(animal!=null)
        PrintAnimalInformation(animal); 
}





void PrintAnimalInformation(IAnimal animal)
{
    Console.WriteLine(animal);
}