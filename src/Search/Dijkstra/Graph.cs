namespace Search.Dijkstra;
public class Graph
{
    public HashSet<GraphNode> Nodes { get; private set; }

    public Graph() => Nodes = new HashSet<GraphNode>();

    public Graph AddNode(GraphNode nodeA)
    {
        Nodes.Add(nodeA);
        return this;
    }
}