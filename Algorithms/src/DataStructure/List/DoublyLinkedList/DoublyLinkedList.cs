namespace Algorithms.DataStructure.List.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public DoublyNode<T> FirstNode { get; set; }
        public int Size { get; set; }

        public DoublyLinkedList<T> Add(DoublyNode<T> node)
        {
            if (node is null)
                return this;

            node.NextNode = null;

            if (FirstNode is null)
            {
                FirstNode = node;
                Size++;
                return this;
            }

            var temp = FirstNode;

            while (temp.NextNode is not null)
                temp = temp.NextNode;

            temp.NextNode = node;
            node.LastNode = temp;

            Size++;
            return this;
        }

        public DoublyNode<T> Search(int? key = null)
        {
            if (FirstNode is null)
                return null;

            var temp = FirstNode;

            for (var i = 0; i < Size; i++)
            {
                if (temp.Key.Equals(key))
                    return temp;

                temp = temp.NextNode;
            }

            return null;
        }

        public DoublyLinkedList<T> Remove(int? key = null)
        {
            if (FirstNode is null)
                return this;

            if (FirstNode.Key.Equals(key))
            {
                FirstNode = FirstNode.NextNode;
                FirstNode.LastNode = null;
                Size--;
                return this;
            }

            var temp = FirstNode;
            var i = 0;
            while (temp.NextNode is not null && !temp.NextNode.Key.Equals(key) && i < Size)
            {
                temp = temp.NextNode;
                i++;
            }

            if (i >= Size || temp.NextNode is null)
                return this;

            temp.NextNode = temp.NextNode.NextNode;

            if (temp.NextNode != null && temp != FirstNode)
                temp.LastNode = temp;

            Size--;
            return this;
        }

        public DoublyLinkedList<T> RemoveAt(int index)
        {
            if (FirstNode is null || index > Size - 1)
                return this;

            if (index == 0)
            {
                FirstNode = FirstNode.NextNode;
                FirstNode.LastNode = null;
                Size--;
                return this;
            }

            var temp = FirstNode;
            var i = 0;
            while (i < Size)
            {
                if (i == index - 1)
                    i = Size;
                else
                    temp = temp.NextNode;

            }

            temp.NextNode = temp.NextNode.NextNode;


            if (temp.NextNode is not null)
            {
                if (temp != FirstNode)
                    temp.LastNode = temp;

                temp.NextNode.LastNode = temp;
            }


            Size--;
            return this;
        }

        public void Traverse()
        {
            if (FirstNode is null) return;

            var temp = FirstNode;

            while (temp.NextNode is not null)
            {
                Console.Write(temp.Key + " -> ");
                temp = temp.NextNode;
            }
            Console.WriteLine(temp.Key);

            while (temp.LastNode is not null)
            {
                Console.Write(temp.Key + " <- ");
                temp = temp.LastNode;
            }

            Console.WriteLine(temp.Key);
        }
    }
}
