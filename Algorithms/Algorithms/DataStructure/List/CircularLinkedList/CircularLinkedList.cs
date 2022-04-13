namespace Algorithms.DataStructure.List.CircularLinkedList
{
    public class CircularLinkedList<T>
    {
        public CircularNode<T> FirstNode { get; set; }
        public CircularNode<T> LastNode { get; set; }
        public int Size { get; set; }

        public CircularLinkedList() => Console.WriteLine($"Class: {GetType().Name}");

        public CircularLinkedList<T> Add(CircularNode<T> node)
        {
            if (node is null)
                return this;

            if (FirstNode is null)
            {
                FirstNode = node;
                LastNode = node;
                node.NextNode = node;
                Size++;
                return this;
            }

            LastNode.NextNode = node;
            LastNode = node;
            node.NextNode = FirstNode;
            Size++;
            return this;
        }

        public CircularNode<T> Search(int? key = null)
        {
            if(FirstNode is null) return null;

            var temp = FirstNode;

            for(var i = 0; i < Size; i++)
            {
                if(temp.Key.Equals(key))
                    return temp;

                 temp = temp.NextNode;
            }

            return null;
        }

        public CircularLinkedList<T> Remove(int? key = null)
        {
            if (FirstNode is null) 
                return this;

            if(FirstNode.Key.Equals(key))
            {
                LastNode.NextNode = FirstNode.NextNode;
                FirstNode = FirstNode.NextNode;
                Size--;
                return this;
            }

            var temp = FirstNode;
            var i = 0;
            while (temp.NextNode != null && !temp.NextNode.Key.Equals(key) && i<Size)
            {
                temp = temp.NextNode;
                i++;
            }

            if (i >= Size || temp.NextNode is null) 
                return this;

            if (LastNode == temp.NextNode)
                LastNode = temp;

            temp.NextNode = temp.NextNode.NextNode;

            Size--;
            return this;
        }

        public CircularLinkedList<T> RemoveAt(int index)
        {
            //TODO: implement this

            return this;
        }

        public void Traverse()
        {
            if (FirstNode is null) return;

            var temp = FirstNode;

            for(int i=0; i<Size-1; i++)
            {
                Console.Write(temp.Key + " -> ");
                temp = temp.NextNode;
            }
            Console.WriteLine(temp.Key);
        }
    }
}
