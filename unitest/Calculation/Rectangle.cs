public class Rectangle:IShape
{
    private int length, width;
    private double area;

    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area
    {
        get{ return area; }
    }

    public void CalculateArea()
    {
        this.area = width * length;
    }
}