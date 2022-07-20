namespace Search.AStar;
public class Edge
{
    public Edge() { }
    public Edge(Vertex current, Vertex predecessor, double weighted, string name, double key = double.MinValue)
    {
        Current = current;
        Predecessor = predecessor;
        Weighted = weighted;
        Name = name;
        Key = key;
    }

    public Vertex Current { get; set; }
    public Vertex Predecessor { get; set; }
    public double Weighted { get; set; }
    public string Name { get; set; }
    public double Key { get; }
}