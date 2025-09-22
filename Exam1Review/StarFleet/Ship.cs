

public class Ship
{
    private Alien[] aliens;
    private int totalCrews = 0;
    private int totalDistanceTravelled;

    //read only mean get no set
    public int TotalDistanceTravelled
    {
        get { return totalDistanceTravelled; }
    }


    //read only with auto property
    public int CurrentWarpSpeed
    {
        get;

        private set;
    }

    public string Name
    {
        get;
        private set;
    }

    public Ship()
    {
        aliens = new Alien[10];
        totalDistanceTravelled = 0;
        CurrentWarpSpeed = 0;
        Name = "Unidentified Flying Object";
        totalCrews = 0;
    }

    public Ship(string name, int capacity)
    {
        aliens = new Alien[capacity];
        totalDistanceTravelled = 0;
        CurrentWarpSpeed = 0;
        Name = name;
        totalCrews = 0;
    }

    public bool Add(Alien alien)
    {
        //we cant add if full
        if (totalCrews == aliens.Length)
        {
            return false;
        }

        int index = -1;

        //search for spot
        for (int i = 0; i < aliens.Length; i++)
        {
            //alien already on ship
            Alien onboard = aliens[i];

            //find empty spot?
            if (onboard == null && index == -1)
            {
                index = i;
            }
            //checking for role duplication captain and chief officer
            if (onboard!=null && alien.IsCaptainOrChiefOfficer() && onboard.Role == alien.Role)
            {
                return false;
            }
        }

        aliens[index] = alien;
        totalCrews++;

        return true;
        
    }

    public bool Remove(string name)
    {
        if (totalCrews == 0)
        {
            return false;
        }

        for (int i = 0; i < aliens.Length; i++)
        {
            if (aliens[i] != null && aliens[i].Name.ToLower() == name.ToLower())
            {
                aliens[i] = null;
                totalCrews--;
                return true;
            }
        }

        return false;
    }

    public void Fly()
    {
        totalDistanceTravelled += 5;
        CurrentWarpSpeed += 3;
    }

    public void Fly(int warpSpeed)
    {
        CurrentWarpSpeed += warpSpeed;
        
        int repeat = warpSpeed / 3;
        totalDistanceTravelled += repeat * 5;
    }

    public override string ToString()
    {
        string info = $"Ship Name: {Name}\nSpeed:{CurrentWarpSpeed}\nDistance:{TotalDistanceTravelled}\nTotal Crew:{totalCrews}\n";
        info += "Crews:\n";

        for (int i = 0; i < aliens.Length; i++)
        {
            Alien alien = aliens[i];
            if (alien != null)
            {
                //alien to string already have name:{name} role:{role}
                info += alien + "\n";
            }
        }

        return info;

    }
}