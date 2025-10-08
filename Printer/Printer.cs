public class Printer
{
    private int[] jobs;
    private int size;


    public Printer(int capacity)
    {
        this.jobs = new int[capacity];
        this.size = 0;

    }

    public bool Add(int job)
    {
        //full cant add more
        if (this.size == this.jobs.Length)
        {
            return false;
        }

        for (int i = 0; i < this.jobs.Length; i++) {
            if (this.jobs[i] == 0)
            {
                this.jobs[i] = job;
                break;
            }
        }
        this.size++;
        return true;
    }

    public int Print()
    {
        if (this.size == 0)
        {
            return -1;
        }

        for (int i = 0; i < this.jobs.Length; i++)
        {
            if (this.jobs[i] != 0)
            {
                int doc = this.jobs[i];

                this.jobs[i] = 0;
                this.size--;
                return doc;
            }
        }

        return -1;
    }

    public bool Cancel(int job)
    {
        if (this.size == 0)
            return false;

        for (int i = 0; i < this.jobs.Length; i++)
        {
            if (this.jobs[i] == job)
            {
                this.jobs[i] = 0;
                this.size--;
                return true;
            }
        }

        return false;
    }

}