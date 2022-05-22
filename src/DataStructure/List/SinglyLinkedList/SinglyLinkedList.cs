namespace DataStructure.List.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyNode<T> FirstNode { get; private set; }
        public int Size { get; private set; }

        public SinglyLinkedList<T> Add(SinglyNode<T> node)
        {
            if (node is null || node.Key is null)
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

            Size++;
            return this;
        }

        public SinglyNode<T> Search(int? key = null)
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

        public SinglyLinkedList<T> Remove(int? key = null)
        {
            if (FirstNode is null)
                return this;

            if (FirstNode.Key.Equals(key))
            {
                FirstNode = FirstNode.NextNode;
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

            Size--;
            return this;
        }

        public SinglyLinkedList<T> RemoveAt(int index)
        {
            if (FirstNode is null || index > Size - 1 || index < 0)
                return this;

            if (index == 0)
            {
                FirstNode = FirstNode.NextNode;
                Size--;
                return this;
            }

            var temp = FirstNode;

            for (var i = 0; i < Size; i++)
            {
                if (i == index - 1)
                    i = Size;
                else
                    temp = temp.NextNode;
            }

            temp.NextNode = temp.NextNode.NextNode;

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
        }
    }
}
