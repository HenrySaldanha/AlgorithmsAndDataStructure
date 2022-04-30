using DataStructure.Graph;

namespace Search.BreadthFirstSearch
{
    public class BreadthFirstSearch
    {
        public AdjacencyListWeightless GraphStructure { get; private set; }
        public int[] Level { get; private set; }

        public BreadthFirstSearch(AdjacencyListWeightless graph)
        {
            GraphStructure = graph;
            Level = new int[GraphStructure.Graph.Length];

            for (int i = 0; i < GraphStructure.Graph.Length; i++)
                Level[i] = -1;
        }

        public void Bfs(int origin)
        {
            var queue = new Queue<int>();
            queue.Enqueue(origin);
            Level[origin] = 0;

            while (queue.Any())
            {
                var u = queue.Dequeue();
                foreach (var item in GraphStructure.Graph[u])
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
