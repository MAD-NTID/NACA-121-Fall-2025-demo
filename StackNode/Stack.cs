public class Stack<T>
{
    private int capacity;
    private const int UNLIMITED = -1;
    private Node<T> top;
    private int count;
    public int Count { get{ return count; } }


    public Stack()
    {
        this.capacity = UNLIMITED;
        this.top = null;
        this.count = 0;
    }
    public Stack(int capacity)
    {
        this.capacity = capacity;
        this.top = null;
        this.count = 0;
    }

    public void Push(T value)
    {
        //check if the stack is full if the user 
        //did use stack(capacity)
        if (this.capacity != UNLIMITED)
        {
            if (this.count == this.capacity)
            {
                throw new Exception("Stack is full!");
            }
        }

        //can add
        Node<T> node = new Node<T>(value, top);
        top = node;
        count++;
    }

    public T Peek()
    {
        return top.Data;
    }

    public T Pop()
    {
        T temp = top.Data;
        count--;

        //move the pointer
        top = top.Next;

        return temp;
    }

    public void Clear()
    {
        top = null;
        count = 0;
    }

    public bool Contains(T obj)
    {
        if (top is not null)
        {
            //make a copy so we dont destroy the orignal
            Node<T> copy = top;
            while (copy != null)
            {
                if (EqualityComparer<T>.Default.Equals(copy.Data, obj))
                {
                    return true;
                }
                else
                {
                    //move up the copy
                    copy = copy.Next;
                }
            }
        }

        return false;
    }

    public T[] ToArray()
    {
        int size = count;
        T[] elements = new T[size];
        int index = 0;

        //top secret code here
      //make a copy so we dont destroy the orignal
        Node<T> copy = top;
        while (copy != null)
        {
            elements[index] = copy.Data;
            index++;
            //move up the copy
            copy = copy.Next;
            
        }
        

        return elements;
    }

    public override string ToString()
    {
        if (top == null)
            return "null";
        return top.ToString();
    }

}