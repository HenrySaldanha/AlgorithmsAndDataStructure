namespace Search.Prim;
public class PrimAlgorithm
{
    public int[,] GetMinimalSpanningTree(int[,] graph)
    {
        var graphResponse = new int[graph.GetLength(0), graph.GetLength(0)];
        var parent = new int[graph.GetLength(0)];
        var minimalDistances = new int[graph.GetLength(0)];
        var visitedNodes = new bool[graph.GetLength(0)];

        for (var i = 0; i < graph.GetLength(0); i++)
            minimalDistances[i] = int.MaxValue;

        minimalDistances[0] = 0;
        parent[0] = -1;

        for (var i = 0; i < graph.GetLength(0) - 1; i++)
        {
            var u = GetSmallestEdgeIndex(minimalDistances, visitedNodes);
            visitedNodes[u] = true;

            for (var v = 0; v < graph.GetLength(0); v++)
            {
                if (Convert.ToBoolean(graph[u, v]) && !visitedNodes[v] && graph[u, v] < minimalDistances[v])
                {
                    parent[v] = u;
                    minimalDistances[v] = graph[u, v];
                }
            }
        }

        for (var i = 1; i < graph.GetLength(0); i++)
        {
            graphResponse[parent[i], i] = graph[i, parent[i]];
            graphResponse[i, parent[i]] = graph[i, parent[i]];
        }

        return graphResponse;
    }

    private int GetSmallestEdgeIndex(int[] key, bool[] visitedNodes)
    {
        var min = int.MaxValue;
        var minIndex = 0;

        for (var v = 0; v < visitedNodes.Length; ++v)
        {
            if (!visitedNodes[v] && key[v] < min)
                (min, minIndex) = (key[v], v);
        }

        return minIndex;
    }
}