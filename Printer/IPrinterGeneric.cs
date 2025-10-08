public interface IPrinterGeneric<T>
{
    public bool Add(T job);

    public T Print();

    public bool Cancel(T job);
}