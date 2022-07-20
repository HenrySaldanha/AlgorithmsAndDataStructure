namespace Search.AStar;
public class Vertex
{
    public Vertex(double weighted)
    {
        Weighted = weighted;
        Guid = Guid.NewGuid();
        Edges = new List<Edge>();
    }

    public Guid Guid { get; private set; }
    public double Weighted { get; set; }
    public List<Edge> Edges { get; }

    public Edge AddEdge(Vertex vertex, double weighted, bool directed, string name)
    {
        var edge = new Edge(this, vertex, weighted, name);

        Edges.Add(edge);
        if (!directed)
            vertex?.AddEdge(this, weighted, true, name);

        return Edges.Last();
    }
}