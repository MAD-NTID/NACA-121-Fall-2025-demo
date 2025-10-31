public class Queue<T>
{
    private T[] elements;
    private int front, back, size;
    public int Size { get { return size; } }

    public Queue(int capacity)
    {
        elements = new T[capacity];
        front = -1;
        back = -1;
        size = 0;
    }

    public T Peek()
    {
        if (front == -1)
            throw new Exception("Queue is empty");

        return elements[front];
    }

    public void Enqueue(T element)
    {
        if (elements.Length == size)
        {
            throw new Exception("Array IS full bruh!\n GO kick rock");
        }
        if (size == 0)
            front = 0;

        back = (back + 1) %  elements.Length;
        elements[back] = element;
        size++;
    }

    public T Dequeue()
    {
        if (size == 0)
            throw new Exception("Array is empty");

        T temp = elements[front];
        size--;
        elements[front] = default;
        front = (front + 1) % elements.Length;
        return temp;
    }
    
    public override string ToString()
    {
        if (size == 0)
            return "null";

        string info = "";
        int count = 0;
        int index = front;
        while(count < size)
        {
            info += elements[index] + "-->";
            index = (index + 1) % elements.Length;
            count++;
        }

        return info + "null";
    }

}