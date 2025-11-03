using System.Collections;

public class Queue<T>:IEnumerable
{
    private Node<T> front,back;
    // private Node<T> back;
    private int capacity;
    private int count;
    private const int UNLIMITED_CAPACITY = -1;

    public int Capacity { get { return capacity; } }
    public int Count { get { return count; } }

    public Queue():this(UNLIMITED_CAPACITY)
    {
     
        // this.count = 0;
        // this.capacity = UNLIMITED_CAPACITY;
        // this.front = this.back = null;
    }

    public Queue(int capacity)
    {
        this.count = 0;
        this.capacity = capacity;
        this.front = this.back = null;
    }

    public void Clear()
    {
        this.count = 0;
        this.front = this.back = null;
    }

    public void Enqueue(T element)
    {
        //full
        if (this.capacity != UNLIMITED_CAPACITY && this.capacity == count)
            throw new Exception("Queue is full!");

        Node<T> node = new Node<T>(element);
        if (this.front is null)
        {
            this.front = this.back = node;
        }
        else
        {
            this.back.Next = node;
            this.back = node;
        }

        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
            throw new Exception("Queue is empty!");

        T temp = this.front.Data;
        this.front = this.front.Next;
        if (this.front is null)
            this.back = null;
        count--;
        return temp;

    }

    public override string ToString()
    {
        if (this.front is null)
            return "null";

        return this.front.ToString();
    }

    public bool Contains(T element)
    {
        Node<T> copy = this.front;
        while (copy is not null)
        {
            if (EqualityComparer<T>.Default.Equals(copy.Data, element))
                return true;

            //move to the next element
            copy = copy.Next;
        }

        return false;
    }

    public T Peek()
    {
        return this.front.Data;
    }

    public T[] ToArray()
    {
        if (count == 0)
            return [];

        T[] elements = new T[count];
        // int index = 0;
        Node<T> copy = this.front;
        // while (copy is not null)
        // {
        //     elements[index] = copy.Data;

        //     //move to the next element
        //     copy = copy.Next;
        // }

        for (int i = 0; i < count; i++)
        {
            elements[i] = copy.Data;
            copy = copy.Next;
        }

        return elements;

    }

    public IEnumerator<T> customEnumerator()
    {
        
        Node<T> copy = this.front;
        for (int i = 0; i < count; i++)
        {
            yield return copy.Data;
            copy = copy.Next;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return customEnumerator();
    }
}