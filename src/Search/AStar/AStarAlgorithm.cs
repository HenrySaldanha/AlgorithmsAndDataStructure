namespace Search.AStar;
public static class AStarAlgorithm
{
    public static IEnumerable<Edge> FindPath(this Vertex first, Vertex target)
    {
        var openOrderedSet = new PriorityQueue<Edge>();
        var path = new Dictionary<Guid, double>();
        var firstEdge = new Edge(first, null, 0, string.Empty, first.Weighted);

        openOrderedSet.Enqueue(firstEdge, firstEdge.Key);
        path.Add(first.Guid, first.Weighted);

        var response = new List<(Guid Key, Edge Edge)>();

        while (openOrderedSet.Count != 0)
        {
            var openVertex = openOrderedSet.Dequeue();
            var currentVertex = openVertex.Current;
            path.Remove(currentVertex.Guid);
            response.Add((currentVertex.Guid, openVertex));

            if (currentVertex.Equals(target))
                return response.Select(c => c.Edge);

            foreach (var edge in currentVertex.Edges)
            {
                if (response.Any(c => c.Key == edge.Predecessor.Guid))
                    continue;

                var newWeighted = openVertex.Weighted + edge.Weighted;
                var nextVertex = new Edge();
                var edgeKey = edge.Predecessor.Guid;
                var edgeListNode = new List<Edge>();
                var oldKey = double.MinValue;

                if (path.ContainsKey(edgeKey))
                {
                    nextVertex = GetNextVertex(openOrderedSet, path[edgeKey], edge.Predecessor);
                    oldKey = nextVertex.Key;
                }

                if (path.ContainsKey(edgeKey))
                {
                    if (newWeighted >= nextVertex.Weighted)
                        continue;

                    edgeListNode.Remove(nextVertex);
                    if (edgeListNode.Count == 0)
                        openOrderedSet.Remove(oldKey);

                    path.Remove(edgeKey);
                }

                nextVertex = new Edge(edge.Predecessor, currentVertex, newWeighted, edge.Name, newWeighted + edge.Predecessor.Weighted);
                openOrderedSet.Enqueue(nextVertex, nextVertex.Key);
                path.Add(edgeKey, nextVertex.Key);
            }
        }

        return Enumerable.Empty<Edge>();
    }

    private static Edge GetNextVertex(PriorityQueue<Edge> queue, double key, Vertex vertex)
    {
        var node = queue.GetNode(key);
        var list = node.Neighbors.ToList();

        return list.FirstOrDefault(c => c.Current == vertex) ?? new Edge();
    }
}