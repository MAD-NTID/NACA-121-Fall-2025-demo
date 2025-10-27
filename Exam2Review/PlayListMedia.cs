public abstract class PlayListMedia<T> : IPlayListMedia<T>
{
    public int TotalMedia
    {
        get{ return totalMedia; }
    }
    protected int totalMedia;

    public PlayListMedia()
    {
        totalMedia = 0;
    }
    public abstract void Add(T media);

    public abstract T Play();


    public abstract T ShowNextMedia();
}