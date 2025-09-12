public class Marker
{
    //the class attribute (What the class have)
    private double inkLevel;
    private bool isCapOn;
    private string color;

    public string Color
    {
        set
        {
            //value is the hidden parameter..
            //same idea setColor(<value>)
            if (string.IsNullOrEmpty(value))
            {
                color = "N/A";
            }
            else
            {
                color = value;
            }
        }
        get
        {
            return color;
        }
    }
    public double Ink
    {
        set
        {
            if(value < 0 || value > 0)
            {
                inkLevel = 0;
            }
            else
            {
                inkLevel = value;
            }
        }
        get
        {
            return inkLevel;
        }
    }
    public bool IsCapOn
    {
        set
        {
            isCapOn = value;
        }
        get
        {
            return isCapOn;
        }
    }

    //Default constructor
    public Marker()
    {
        //setting up default values
        inkLevel = 0;
        isCapOn = true;
        Color = "N/A";
    }

    //Parameterized constructor
    public Marker(double level, bool covered, string colorLabel)
    {
        // if (level < 0)
        // {
        //     inkLevel = 0;
        // }
        // else
        // {
        //     inkLevel = level;
        // }
        // if (string.IsNullOrEmpty(colorLabel))
        // {
        //     color = "N/A";
        // }
        // else
        // {
        //     color = colorLabel;
        // }
        Color = colorLabel;

        isCapOn = covered;

    }

    //make method to allow changes
    // public void SetColor(string colorLabel)
    // {
    //     if (string.IsNullOrEmpty(colorLabel))
    //     {
    //         color = "N/A";
    //     }
    //     else
    //     {
    //         color = colorLabel;
    //     }

    // }
    // public void SetLevelInk(double ink)
    // {
    //     if (ink < 0 || ink > 100)
    //     {
    //         inkLevel = 0;
    //     }
    //     else
    //     {
    //         inkLevel = ink;
    //     }
    // }


    // public void SetIsCapOn(bool isCapOn2)
    // {
    //     isCapOn = isCapOn2;
    // }

    // public string GetColor()
    // {
    //     return color;
    // }
    // public bool GetIsCapOn()
    // {
    //     return isCapOn;
    // }
    
    // public double GetInkLevel()
    // {
    //     return inkLevel;
    // }

}