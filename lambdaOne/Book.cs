public class Book
{
    //get only
    private string Name => "Book Name";

    //get set
    private int version;
    public int Version
    {
        set=> version = value;
        get=> version;
    }
}