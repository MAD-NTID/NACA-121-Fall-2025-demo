public class Square : IShape
{
    private int length;
    private int area;

    public Square(int length)
    {
        this.length = length;
    }
    public double Area
    {
        get
        {
            return area;
        }
    }

    public void CalculateArea()
    {
        this.area = length * length;
    }
}