// string filename = "myfile.txt";

// StreamWriter writer = new StreamWriter(filename);
// writer.WriteLine("Please store this on a file. Thank you!");
// writer.Close();

// //let the user know the operation was success
// Console.WriteLine($"Successfully written to the file {filename}");

using System.Runtime.CompilerServices;

string statsFile = "game_stats.csv";
if (File.Exists(statsFile))
{
    StreamReader reader = new StreamReader(statsFile);
    Player[] players = new Player[60];

    Console.WriteLine("Reading player info from the file game_stats.csv");
    int lineNumber = 1;
    reader.ReadLine(); //skip the header
    while (!reader.EndOfStream)
    {
        string line = reader.ReadLine();
        //Console.WriteLine($"Line {lineNumber}: {line}");
        //parse out the game stats
        //player_name,kills,death,losses,wins,matches
        string[] items = line.Split(",");
        string name = items[0];
        int kills = int.Parse(items[1]);
        int deaths = int.Parse(items[2]);
        int losses = int.Parse(items[3]);
        int wins = int.Parse(items[4]);
        int matches = int.Parse(items[5]);

        Player player = new Player(name, kills, deaths, losses, wins, matches);
        players[lineNumber - 1] = player;
        lineNumber++;
    }

    reader.Close();
    Console.WriteLine("Finish load player stats");

    Console.WriteLine("Showing all players stats");

    for(int i = 0; i < players.Length; i++)
    {

        Player player = players[i];
        if(player is not null)
        {
            Console.WriteLine(player);
            Console.WriteLine();
        }

    }

    //add 1 more player
    StreamWriter writer = new StreamWriter(statsFile, true);
    writer.WriteLine("Player51,25,10,3,7,10");
    writer.Close();
    Console.WriteLine("Successfully added 51th player to the csv file");



    StreamWriter writer2 = new StreamWriter("game_stats2.csv");
    writer2.WriteLine("player_name,kills,death,losses,wins,matches");
    for (int i = 0; i < players.Length; i++)
    {
        Player player = players[i];
        if (player is not null)
        {
            writer2.WriteLine($"{player.Name},{player.Kills},{player.Deaths},{player.Losses},{player.Wins},{player.Matches}");
        }
    }

    Console.WriteLine("Successfully write player info to game_stats2.csv");
    writer2.Close();

    }
else
{
    Console.WriteLine($"Error: There is no file {statsFile}");
}



