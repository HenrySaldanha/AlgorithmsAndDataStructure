namespace Search.Dijkstra;
public class GraphNode
{
    public string Name { get; private set; }

    public List<GraphNode> ShortestPath { get; set; }

    public int Distance { get; set; }

    public Dictionary<GraphNode, int> AdjacentNodes { get; private set; }

    public GraphNode AddDestination(GraphNode destination, int distance)
    {
        AdjacentNodes.Add(destination, distance);
        return this;
    }

    public GraphNode(string name)
    {
        Name = name;
        Distance = int.MaxValue;
        AdjacentNodes = new Dictionary<GraphNode, int>();
        ShortestPath = new List<GraphNode>();
    }
}