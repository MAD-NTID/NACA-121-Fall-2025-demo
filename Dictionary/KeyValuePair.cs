public class KeyValuePair<TKey, TValue> : IKeyValuePair<TKey, TValue>
{
    private TKey key;
    private TValue value;

    public KeyValuePair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }

    public override string ToString()
    {
        return $"{key}-->{value}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not KeyValuePair<TKey, TValue>)
            return false;

        KeyValuePair<TKey, TValue> copy = (KeyValuePair<TKey, TValue>)(obj);

        bool keyEquals = EqualityComparer<TKey>.Default.Equals(copy.key, this.key);
        bool valueEquals = EqualityComparer<TValue>.Default.Equals(copy.value, this.value);

        return keyEquals && valueEquals;

    }

    public TKey Key{get{ return key; }}

    public TValue Value{get{ return value; }}
}