using DataStructure.Graph;

namespace Search.DepthFirstSearch
{
    public class DepthFirstSearch 
    {
        public AdjacencyListWeightless GraphStructure { get; private set; }
        public bool[] Visited { get; private set; }

        public DepthFirstSearch(AdjacencyListWeightless graph)
        {
            GraphStructure = graph;
            Visited = new bool[GraphStructure.Graph.Length];
        }

        public string Dfs(int origin)
        {
            var r = origin.ToString();
            Visited[origin] = true;

            foreach (var item in GraphStructure.Graph[origin])
            {
                if (!Visited[item])
                    r += Dfs(item);
            }
            return r;
        }
    }
}
