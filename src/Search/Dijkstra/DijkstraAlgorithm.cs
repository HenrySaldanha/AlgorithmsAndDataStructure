namespace Search.Dijkstra
{
    public static class DijkstraAlgorithm
    {
        public static Graph SearchShortestPathFromSource(this Graph graph, GraphNode source)
        {
            source.Distance = 0;
            var visited = new HashSet<GraphNode>();
            var unvisited = new HashSet<GraphNode> { source };

            while (unvisited.Any())
            {
                var currentNode = unvisited.GetMinimumDistanceNode();
                unvisited.Remove(currentNode);
                foreach (var (adjacentNode, edgeWeight) in currentNode.AdjacentNodes)
                {
                    if (!visited.Contains(adjacentNode))
                    {
                        if (currentNode.Distance + edgeWeight < adjacentNode.Distance)
                        {
                            adjacentNode.Distance = currentNode.Distance + edgeWeight;
                            adjacentNode.ShortestPath = new List<GraphNode>(currentNode.ShortestPath) { currentNode };
                        }

                        unvisited.Add(adjacentNode);
                    }
                }

                visited.Add(currentNode);
            }

            return graph;
        }

        private static GraphNode GetMinimumDistanceNode(this HashSet<GraphNode> unvisited)
        {
            var lowestDistanceNode = new GraphNode("");
            foreach (var node in unvisited)
            {
                if (node.Distance < lowestDistanceNode.Distance)
                    lowestDistanceNode = node;
            }

            return lowestDistanceNode;
        }
    }
}