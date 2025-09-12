public class Marker
{
    //the class attribute (What the class have)
    public double inkLevel;
    public bool isCapOn;
    public string color;

    //Default constructor
    public Marker()
    {
        //setting up default values
        inkLevel = 0;
        isCapOn = true;
        color = "N/A";
    }

    //Parameterized constructor
    public Marker(double level, bool covered, string colorLabel)
    {
        if (level < 0)
        {
            inkLevel = 0;
        }
        else
        {
            inkLevel = level;
        }
        if (string.IsNullOrEmpty(colorLabel))
        {
            color = "N/A";
        }
        else
        {
            color = colorLabel;
        }
        
        isCapOn = covered;
        
    }


}