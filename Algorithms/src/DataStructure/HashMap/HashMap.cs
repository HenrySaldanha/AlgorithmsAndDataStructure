namespace DataStructure.HashMap
{
    public class HashMap<K, V>
    {
        private List<HashMapNode<K, V>>[] Buckets;
        public int Size { get; private set; }
        private int LimitSize { get; set; }

        public HashMap<K, V> Add(HashMapNode<K, V> node)
        {
            if (node is null || node.Key is null || node.Value is null)
                return this;

            if (Get(node.Key) != null) return this;

            if (LimitSize == 0)
                LimitSize = 16;

            if (Size == 0)
                Buckets = new List<HashMapNode<K, V>>[LimitSize];

            if (Size > LimitSize * 0.75)
                RearrangeWithNewSize();

            var index = HashFunction(node.Key);

            Buckets[index] ??= new List<HashMapNode<K, V>>();
            Buckets[index].Add(node);
            Size++;
            return this;
        }

        public HashMapNode<K, V> Get(K key)
        {
            if (key is null || Buckets is null)
                return null;

            var index = HashFunction(key);

            if (Buckets[index] is null)
                return null;

            foreach (var node in Buckets[index])
            {
                if (node.Key.Equals(key))
                    return node;
            }

            return null;
        }

        public HashMap<K, V> Remove(K key)
        {
            if (key is null || Buckets is null)
                return null;

            var index = HashFunction(key);

            if (Buckets[index] is null)
                return null;

            foreach (var node in Buckets[index])
            {
                if (node.Key.Equals(key))
                {
                    Buckets[index].Remove(node);
                    Size--;
                    return this;
                }
            }

            return this;
        }

        private int HashFunction(K key) => Math.Abs(key.GetHashCode() % LimitSize);

        private void RearrangeWithNewSize()
        {
            LimitSize *= 2;

            var newHashMap = new List<HashMapNode<K, V>>[LimitSize];

            for (int i = 0; i < Buckets.Length; i++)
            {
                if (Buckets[i] is null) continue;

                foreach (var node in Buckets[i])
                {
                    var index = HashFunction(node.Key);
                    newHashMap[index] ??= new List<HashMapNode<K, V>>();
                    newHashMap[index].Add(node);
                }

            }
            Buckets = newHashMap;
        }
    }
}
