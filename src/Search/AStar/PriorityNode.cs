namespace Search.AStar;
public class PriorityNode<T>
{
    public PriorityNode(double key, T value)
    {
        Key = key;
        Value = value;
        Neighbors = new HashSet<T>();
    }

    public HashSet<T> Neighbors { get; }
    public T Value { get; set; }
    public PriorityNode<T> Parent { get; set; }
    public double Key { get; set; }
    public PriorityNode<T> Left { get; set; }
    public PriorityNode<T> Right { get; set; }
    public int AmountOfNode { get; set; }
}