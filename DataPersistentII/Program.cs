
using Newtonsoft.Json;

Player[] players;
string filename = "stats.json";

//write example
// string filename = "stats.json";
// StreamWriter writer = new StreamWriter(filename);

// Console.WriteLine("Saving the player data to stats.json");
// string jsonString = JsonConvert.SerializeObject(players);
// writer.Write(jsonString);
// writer.Close();
// Console.WriteLine("Successfully save the stats to stats.json");

//reader example
Console.WriteLine("Loading stats.json to players object");
StreamReader reader = new StreamReader(filename);
string playerInfo = reader.ReadToEnd();
players = JsonConvert.DeserializeObject<Player[]>(playerInfo);
Console.WriteLine("Successfully loaded from file");

//show all players objects
for(int i=0; i < players.Length; i++)
{
    Player player = players[i];
    if (player is not null)
        Console.WriteLine(player + "\n");
}



