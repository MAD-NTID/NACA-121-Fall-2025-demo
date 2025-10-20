
public class Player
{
    //player_name,kills,death,losses,wins,matches
    public string Name { get; set; }
    public int Kills { get; set; }
    public int Deaths { get; set; }
    public int Losses { get; set; }
    public int Wins { get; set; }
    public int Matches { get; set; }

    //player_name,kills,death,losses,wins,matches
    public Player(string name, int kills, int deaths, int losses, int wins, int matches)
    {
        Name = name;
        Kills = kills;
        Deaths = deaths;
        Losses = losses;
        Wins = wins;
        Matches = matches;
    }

    public override string ToString()
    {
        return $"Name:{Name}\nKills:{Kills}\nDeaths:{Deaths}";
    }
}