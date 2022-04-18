namespace Algorithms.DataStructure.List.SinglyLinkedList
{
    public class SinglyNode<T>
    {
        public SinglyNode(T key) => Key = key;

        public T Key { get; set; }
        public SinglyNode<T> NextNode { get; set; }
    }
}
