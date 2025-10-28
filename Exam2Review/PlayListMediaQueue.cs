public class PlayListMediaQueue<T> : PlayListMedia<T>
{
    private Queue<T> queue;

    public PlayListMediaQueue():base()
    {
        queue = new Queue<T>(50);
    }
    public override void Add(T media)
    {
        queue.Enqueue(media);
        totalMedia++;
    }

    public override T Play()
    {
        totalMedia--;
        return queue.Dequeue();
    }

    public override T ShowNextMedia()
    {
        return queue.Peek();
    }

    public override string ToString()
    {
        return "Queue playlist:" + queue.ToString();
    }
}