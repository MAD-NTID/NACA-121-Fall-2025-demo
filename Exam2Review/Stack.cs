public class Stack<T>
{
    private T[] elements;
    private int top;
    private int size;
    public int Size{get{ return size; }}

    public Stack(int capacity)
    {
        elements = new T[capacity];
        size = 0;
        top = -1;
    }

    public void Push(T element)
    {
        if(elements.Length == size)
        {
            throw new Exception("Array is full");
        }
        top++;
        elements[top] = element;
        size++;
        

    }

    public T Peek()
    {
        if (top == -1)
            throw new Exception("Out of bound!");

        return elements[top];
    }

    public T Pop()
    {
        T temp = elements[top];
        size--;
        elements[top] = default;
        top--;
        return temp;
    }

    public override string ToString()
    {
        if (size == 0)
            return "null";

        string info = "";

        for (int i = size - 1; i < size; i++)
        {
            info += elements[i] + "-->";
        }

        return info += "null";
    }
}