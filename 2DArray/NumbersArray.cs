public class NumbersArray
{
    private int[,] data;
    public int[,] Data
    {
        get { return data; }
    }

    public int Rows { get; private set; }
    public  int Cols { get; private set; }

    public NumbersArray(int rows, int cols)
    {
        // Creates an array without values
        data = new int[rows, cols];

        Rows = rows;
        Cols = cols;
    }

    public void AddNumberToRowCol(int row, int col, int number)
    {
        // Add a number to a specific 'cell' (row and column) to the 2D Array
        data[row, col] = number;
    }
    
    public int GetNumberFromRowCol(int row, int col)
    {
        return data[row, col];
    }
}