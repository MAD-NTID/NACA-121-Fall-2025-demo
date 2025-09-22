public class Alien
{
    private string name, role;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                name = "Undefined";
            }
            else
            {
                name = value;
            }

        }
    }

    private bool IsValidRole(string role)
    {
        string[] roles = {
            "captain",
            "chief officer",
            "navigator",
            "pilot",
            "engineer",
            "doctor"
        };

        for (int i = 0; i < roles.Length; i++)
        {
            if (role.ToLower() == roles[i])
            {
                return true;
            }
        }

        return false;
    }

    public string Role
    {
        get { return role; }
        set
        {
            if (!IsValidRole(value))
            {
                role = "Unknown role";

            }
            else
            {
                role = value;
            }
        }
    }

    public Alien(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public override string ToString()
    {
        return $"Name:{name} Role: {role}";
        //return $"Name:{Name} Role: {Role}"; - Fine too
    }
}