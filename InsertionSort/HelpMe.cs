public class HelpMe<T>
{
    public int Compare(T x, T y)
    {
        return Comparer<T>.Default.Compare(x,y);
    }

    public bool Greater(T x, T y)
    {
        if(Comparer<T>.Default.Compare(x,y)> 0)
            return true;
        return false;
    }
}