using System.Diagnostics.Contracts;

public class PlayListMediaStack<T> : PlayListMedia<T>
{
    private Stack<T> stack;
    public PlayListMediaStack():base()
    {
        stack = new Stack<T>(50);
    }
    public override void Add(T media)
    {
        stack.Push(media);
        totalMedia++;
    }

    public override T Play()
    {
        totalMedia--;
        return stack.Pop();
    }

    public override T ShowNextMedia()
    {
        return stack.Peek();
    }

    public override string ToString()
    {
        return "Stack playlist:" + stack.ToString();
    }
}