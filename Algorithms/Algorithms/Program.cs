using System;
using Algorithms.DataStructure.Array;
using Algorithms.DataStructure.List.CircularLinkedList;
using Algorithms.DataStructure.List.DoublyLinkedList;

namespace Algorithms
{
    public static class Program
    {
        public static void Main()
        {
            var array = new SimpleArray<int>();
            array.Add(1).Add(2).Add(5).Add(10).Add(8).Traverse();
            array.Remove(1).Traverse();

            var circularLinkedList = new CircularLinkedList<int>();
            circularLinkedList.Add(new CircularNode<int>(2)).Add(new CircularNode<int>(3)).Add(new CircularNode<int>(6)).Add(new CircularNode<int>(4)).Traverse();
            circularLinkedList.Remove(4).Traverse();

            var doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Add(new DoublyNode<int>(2)).Add(new DoublyNode<int>(3)).Add(new DoublyNode<int>(6)).Add(new DoublyNode<int>(4)).Traverse();
            doublyLinkedList.Remove(4).Traverse();
        }
    }
}