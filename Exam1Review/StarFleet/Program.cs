using System.Linq.Expressions;

const int CAPACITY = 3000;
Ship ship = new Ship("Voyager", CAPACITY);

string[] menus = {
    "Add Alien to ship",
    "Fly",
    "Fly at a specific speed",
    "Remove an alien from the ship",
    "Show ship information",
    "Exit"
};

bool repeat = true;
while (repeat)
{
    try
    {
        //show menu
        Console.WriteLine("Menu\n");
        for (int i = 0; i < menus.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menus[i]}");
        }
        Console.WriteLine("Selection:");
        int selection = int.Parse(Console.ReadLine());

        switch (selection)
        {
            case 1:
                bool added = false;
                do
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Role:");
                    string role = Console.ReadLine();
                    Alien alien = new Alien(name, role);
                    added = ship.Add(alien);
                } while (!added);
                break;
            case 2:
                ship.Fly();
                Console.WriteLine($"{ship.Name} flew {ship.TotalDistanceTravelled} interstellar distance at {ship.CurrentWarpSpeed} warp speed");
                break;
            case 3:
                Console.Write("Enter speed in multple of 3:");
                if (int.TryParse(Console.ReadLine(), out int speed) || speed % 3 != 0)
                {
                    Console.WriteLine("Invalid speed! Speed must be an integer in mutliple of 3!\n Ship did not fly!");
                    return;
                }
                ship.Fly(speed);
                Console.WriteLine($"{ship.Name} flew {ship.TotalDistanceTravelled} interstellar distance at {ship.CurrentWarpSpeed} warp speed");
                break;
            case 4:
                Console.Write("Enter the name of the alien to remove:");
                string alienRemove = Console.ReadLine();
                if (ship.Remove(alienRemove))
                {
                    Console.WriteLine($"{alienRemove} was successfully removed");
                }
                else
                {
                    Console.WriteLine($"{alienRemove} doesn’t exis");
                }
                break;
            case 5:
                Console.WriteLine("Ship information\n");
                Console.WriteLine(ship);
                break;
            case 6:
                Console.WriteLine("Thank you for exploring space with us");
                repeat = false;
                break;
            default:
                Console.WriteLine("Invalid Selection!");
                break;

        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Invalid selection. Input must be a digit!");
    }

    
}
