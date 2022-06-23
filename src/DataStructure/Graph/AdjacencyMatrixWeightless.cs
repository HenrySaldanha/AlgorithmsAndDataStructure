namespace DataStructure.Graph;
    public class AdjacencyMatrixWeightless
    {
        public AdjacencyMatrixWeightless(int maxSize)
        {
            MaxSize = maxSize;
            Graph = new bool[MaxSize, MaxSize];
            Visited = new bool[MaxSize];
            Level = new int[MaxSize];

            for (int i = 0; i < MaxSize; i++)
            {
                Level[i] = -1;
            }
        }

        private int MaxSize { get; set; }
        public bool[,] Graph { get; set; }
        private bool[] Visited { get; set; }
        public int[] Level { get; set; }

        public AdjacencyMatrixWeightless AddEdge(int from, int to)
        {
            Graph[from, to] = true;
            Graph[to, from] = true;
            return this;
        }

        public string DepthFirstSearch(int origin)
        {
            var r = origin.ToString();
            Visited[origin] = true;

            for (int i = 0; i < MaxSize; i++)
            {
                if (Graph[origin, i] && !Visited[i])
                    r += DepthFirstSearch(i);
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
                for (int i = 0; i < MaxSize; i++)
                {
                    if (Graph[u, i] && Level[i] == -1)
                    {
                        Level[i] = Level[u] + 1;
                        queue.Enqueue(i);
                    }
                }

            }

        }
    }
