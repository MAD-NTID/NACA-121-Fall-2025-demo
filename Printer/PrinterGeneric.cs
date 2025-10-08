public class PrinterGeneric<T>:IPrinterGeneric<T>
{
    private T[] jobs;
    private int size;


    public PrinterGeneric(int capacity)
    {
        this.jobs = new T[capacity];
        this.size = 0;

    }

    public bool Add(T job)
    {
        //full cant add more
        if (this.size == this.jobs.Length)
        {
            return false;
        }

        for (int i = 0; i < this.jobs.Length; i++) {
            if (this.jobs[i] == null)
            {
                this.jobs[i] = job;
                break;
            }
        }
        this.size++;
        return true;
    }

    public T Print()
    {
        if (this.size == 0)
        {
            return default;
        }

        for (int i = 0; i < this.jobs.Length; i++)
        {
            if (this.jobs[i]!=null)
            {
                T doc = this.jobs[i];

                this.jobs[i] = default;
                this.size--;
                return doc;
            }
        }

        return default;
    }

    public bool Cancel(T job)
    {
        if (this.size == 0)
            return false;

        for (int i = 0; i < this.jobs.Length; i++)
        {
             bool match = EqualityComparer<T>.Default.Equals(jobs[i] ,job);
            if (match)
            {
                this.jobs[i] = default;
                this.size--;
                return true;
            }
        }

        return false;
    }

}