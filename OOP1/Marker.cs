public class Marker
{
    //the class attribute (What the class have)
    public double inkLevel;
    public bool isCapOn;
    public string color;

    //Default constructor
    public Marker()
    {
        
    }

    //Parameterized constructor
    public Marker(double level, bool covered, string colorLabel)
    {
        inkLevel = level;
        isCapOn = covered;
        color = colorLabel;
    }


}