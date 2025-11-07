using System.Runtime.InteropServices;

public class Dictionary<TKey, TValue>
{
    private int capacity;
    public int Capacity { get { return capacity; } }

    private int count;
    public int Count { get { return count; } }

    private IKeyValuePair<TKey, TValue>[] buckets;
    private const double LOAD_FACTOR = 0.70;

    public Dictionary()
    {
        this.capacity = 10;
        this.count = 0;
        buckets = new IKeyValuePair<TKey, TValue>[capacity];
    }

    private int GetIndex(TKey key)
    {
        //c# built in hashcode will tell us the "unique" hash code for the key
        int hash = Math.Abs(key.GetHashCode());

        //make sure it stay in capacity range
        hash = hash % capacity;
        return hash;
    }

    public int LinearProbe(TKey key, bool existingKey = false)
    {
        //start at a specific index
        int startIndex = this.GetIndex(key);
        int index = startIndex;

        do
        {
            IKeyValuePair<TKey, TValue> kvp = this.buckets[index];

            //we are searching for existing key
            if(existingKey && kvp is not null){
                if(EqualityComparer<TKey>.Default.Equals(key, kvp.Key))
                    return index;
            } 
            //we are not in search for existing key mode
            else if(!existingKey && kvp is null) 
            {
                return index;
            }

            index = (index + 1)  % capacity;

        }while(startIndex!=index);


        return -1;


    }

    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
            throw new Exception($"Cannot contain duplicate key:{key}!");


        //grow if need to
        EnsureCapacity();

        //make the pair
        IKeyValuePair<TKey, TValue> kvp = new KeyValuePair<TKey, TValue>(key, value);
        int index = LinearProbe(key);
        buckets[index] = kvp;
        count++;
        // items = IKeyValuePair<key, value>
    }

    public bool Remove(TKey key)
    {
        if (!ContainsKey(key))
            throw new Exception($"Cannot remove non-existence key:{key}");

        int index = LinearProbe(key, true);
        buckets[index] = default;
        count--;
        return true;
    }

    public bool ContainsKey(TKey key)
    {
        //get the location to check "hash function"
        int index = LinearProbe(key, true);


        if (index ==-1)
            return false;


        return true;
    }

    public void Clear()
    {
        count = 0;
        buckets = new IKeyValuePair<TKey, TValue>[capacity];
    }

    public IKeyValuePair<TKey, TValue> Get(TKey key)
    {
        if (ContainsKey(key))
        {
            int index = LinearProbe(key, true);
            IKeyValuePair<TKey, TValue> kvp = buckets[index];
            return kvp;
        }

        throw new Exception($"Key not found:{key}");
    }

    public bool ContainsValue(TValue value)
    {
        if (count == 0)
            return false;


        foreach (IKeyValuePair<TKey, TValue> kvp in buckets)
        {
            if (kvp is not null)
            {
                if (EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
                    return true;
            }
        }

        return false;
    }

    public void EnsureCapacity()
    {
        double percent = this.count / (double)this.capacity;
        //check threshold
        if (percent >= LOAD_FACTOR)
        {

            this.capacity *= 2;
            Console.WriteLine($"I Grew to capacity size:{capacity}");
            IKeyValuePair<TKey, TValue>[] bucketCopy = new IKeyValuePair<TKey, TValue>[capacity];

            for (int i = 0; i < buckets.Length; i++)
            {
                bucketCopy[i] = buckets[i];
            }

            //overwrite old buckets with new copy
            buckets = bucketCopy;
        }
    }
    

}