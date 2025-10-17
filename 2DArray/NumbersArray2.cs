public class NumbersArray2
{
    public int[,] Data ={
    //  col col col which is 1 when calling GetLength()
        {5, 10, 15}, // this is 0 because it is row
        {20, 25, 30} // same here
    };

    public void AddNumberToRowCol(int row, int col, int number)
    {
        // Add a number to a specific 'cell' (row and column) to the 2D Array
        Data[row, col] = number;
    }

    public int GetNumberFromRowCol(int row, int col)
    {
        return Data[row, col];
    }

    public int GetRows()
    {
        // [a, b]
        // When you define an array a being row, b being col
        // Since a is first, then it is 0
        // b is next, then it is 1
        return Data.GetLength(0);
    }
    
    public int GetCols()
    {
        return Data.GetLength(1);
    }
}