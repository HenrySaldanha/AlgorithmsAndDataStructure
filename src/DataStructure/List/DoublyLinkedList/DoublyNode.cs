namespace DataStructure.List.DoublyLinkedList
{
    public class DoublyNode<T>
    {
        public DoublyNode(T key) => Key = key;

        public T Key { get; set; }
        public DoublyNode<T> NextNode { get; set; }
        public DoublyNode<T> LastNode { get; set; }
    }
}
