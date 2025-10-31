public class Node<T>
{
    private T data;
    private Node<T> next;

    public T Data { get { return data; } }
    public Node<T> Next { get { return next; } }

    public Node(T data)
    {
        this.data = data;
        this.next = null;
    }

    public Node(T data, Node<T> next)
    {
        this.data = data;
        this.next = next;
    }

    public override string ToString()
    {
        if (this.next == null)
            return data + "-->null";

        return data + "-->" + next.ToString();
    }
}