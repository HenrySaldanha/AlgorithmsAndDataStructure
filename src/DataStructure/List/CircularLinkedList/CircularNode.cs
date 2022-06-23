namespace DataStructure.List.CircularLinkedList;
public class CircularNode<T>
{
    public CircularNode(T key) => Key = key;

    public T Key { get; set; }
    public CircularNode<T> NextNode { get; set; }
}
