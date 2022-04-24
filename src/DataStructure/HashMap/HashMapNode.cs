namespace DataStructure.HashMap
{
    public class HashMapNode<K, V>
    {
        public HashMapNode(K key, V value)
        {
            Key = key;
            Value = value;
        }

        public K Key { get; set; }

        public V Value { get; set; }
         

    }
}
