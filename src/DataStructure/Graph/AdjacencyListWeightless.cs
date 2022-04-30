namespace DataStructure.Graph
{
    public class AdjacencyListWeightless
    {
        public AdjacencyListWeightless(int maxSize)
        {
            MaxSize = maxSize;
            Graph = new List<int>[MaxSize];
            Visited = new bool[MaxSize];
            Level = new int[MaxSize];

            for (int i = 0; i < MaxSize; i++)
            {
                Graph[i] = new List<int>();
                Level[i] = -1;
            }

        }

        private int MaxSize { get; set; }
        public List<int>[] Graph { get; set; }
        private bool[] Visited { get; set; }
        public int[] Level { get; set; }

        public AdjacencyListWeightless AddEdge(int from, int to)
        {
            Graph[from].Add(to);
            Graph[to].Add(from);
            return this;
        }

        public string DepthFirstSearch(int origin)
        {
            var r = origin.ToString();
            Visited[origin] = true;

            foreach (var item in Graph[origin])
            {
                if (!Visited[item])
                    r += DepthFirstSearch(item);
            }
            return r;
        }

        public void BreadthFirstSearch(int origin)
        {
            var queue = new Queue<int>();
            queue.Enqueue(origin);
            Level[origin] = 0;

            while (queue.Any())
            {
                var u = queue.Dequeue();
                foreach (var item in Graph[u])
                {
                    if (Level[item] == -1)
                    {
                        Level[item] = Level[u] + 1;
                        queue.Enqueue(item);
                    }
                }

            }
        }
    }
}
