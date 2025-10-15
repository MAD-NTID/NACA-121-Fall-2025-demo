public class Game
{
    private Card[,] board;
    private Card[] cards;
    private int totalMatches;

    public bool IsDone
    {
        get
        {
            return totalMatches == cards.Length * 2;
        }
    }

    public Game(int rows, int cols, Card[] cards)
    {
        board = new Card[rows, cols];
        this.cards = cards;
        SetupCards();
    }

    private void SetupCards()
    {
        Random random = new Random();

        for (int i = 0; i < cards.Length; i++)
        {
            Card card = cards[i];
            int placed = 0;

            while (placed != 2)
            {
                //randomly pick a location
                int row = random.Next(0, board.GetLength(0));
                int col = random.Next(0, board.GetLength(1));

                //is the spot empty?
                if (board[row, col] == null)
                {
                    board[row, col] = card;
                    placed++;
                }
            }

        }
    }

    public void Turn(int row1, int col1, int row2, int col2)
    {
        board[row1, col1].Show();
        board[row2, col2].Show();
    }
    
    public bool IsMatch(int row1, int col1, int row2, int col2)
    {
        Card card1 = board[row1, col1];
        Card card2 = board[row2, col2];

        if (card1.Equals(card2))
        {
            totalMatches += 2;
            return true;
        }

        return false;
    }
    
    public void ShowBoard()
    {
        for(int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                Card card = board[row, col];
                if(card is not null)
                {
                    //if the card is flipped, show the picture
                    if (card.Flipped)
                        Console.Write(card.Picture + "|");
                    else
                        //show *
                        Console.Write("*|");
                }
                    
            }
            Console.WriteLine();
        }
    }



}