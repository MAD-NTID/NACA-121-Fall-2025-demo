public class Dictionary<TKey, TValue>
{
    private int capacity;
    public int Capacity { get { return capacity; } }

    private int count;
    public int Count { get { return count; } }

    private IKeyValuePair<TKey, TValue>[] buckets;
    //private const double LOAD_FACTOR = 0.70; - hold for friday

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

    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
            throw new Exception($"Cannot contain duplicate key:{key}!");

        //make the pair
        IKeyValuePair<TKey, TValue> kvp = new KeyValuePair<TKey, TValue>(key, value);
        int index = GetIndex(key);
        buckets[index] = kvp;
        count++;
        // items = IKeyValuePair<key, value>
    }

    public bool Remove(TKey key)
    {
        if (!ContainsKey(key))
            throw new Exception($"Cannot remove non-existence key:{key}");

        int index = GetIndex(key);
        buckets[index] = null;
        count--;
        return true;
    }

    public bool ContainsKey(TKey key)
    {
        //get the location to check "hash function"
        int index = GetIndex(key);

        //check if location is not null
        IKeyValuePair<TKey, TValue> kvp = buckets[index];
        if (kvp is null)
            return false;

        // if (!EqualityComparer<TKey>.Default.Equals(key, kvp.Key))
        //     return false;

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
            int index = GetIndex(key);
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
    

}