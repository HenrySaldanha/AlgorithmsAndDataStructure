namespace DataStructure.HashMap;
public class HashMapNode<K, V>
{
    public HashMapNode(K key, V value)
    {
        Key = key;
        Value = value;
    }

    public K Key { get; private set; }

    public V Value { get; private set; }


}
