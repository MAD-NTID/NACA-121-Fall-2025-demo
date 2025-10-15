// Card card = new Card("Fish", "Red", "Fish");
// Card card2 = new Card("Fish", "Red", "Fish");
// card2.Show();
// Console.WriteLine(card);
// card.Show();
// Console.WriteLine(card);

// Console.WriteLine("Matching card:");
// Console.WriteLine(card.Equals(card2));

Card[] cards =
{
    new Card("Fish", "Red", "Fish"),
    new Card("Turtle", "Blue", "Turtle"),

};
Game game = new Game(2, 2, cards);
// game.Turn(0, 0, 0, 1);
// game.ShowBoard();

while(!game.IsDone)
{
    game.ShowBoard();
    Console.WriteLine("Enter the coordinate of the first card separate by , eg 0,0");
    string[] firstCard = Console.ReadLine().Split(",");
    Console.WriteLine("Enter the coordinate of the second card separate by , eg 0,0");
    string[] secondCard = Console.ReadLine().Split(",");

    int row1 = int.Parse(firstCard[0]);
    int col1 = int.Parse(firstCard[1]);
    int row2 = int.Parse(secondCard[0]);
    int col2 = int.Parse(secondCard[1]);

    //flip for match
    game.Turn(row1, col1, row2, col2);
    if(game.IsMatch(row1, col1, row2, col2))
    {
        Console.WriteLine("Congratulation, you found a match");
    }else
    {
        Console.WriteLine("No match!");
    }
}
