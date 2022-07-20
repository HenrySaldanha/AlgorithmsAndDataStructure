namespace Search.AStar;
public class PriorityQueue<T>
{
    private PriorityNode<T> RootNode { get; set; }
    public int Count { get; private set; }

    public IComparable Enqueue(T data, double key)
    {
        Add(key, data);
        return key;
    }

    private void Add(double key, T data)
    {
        var newNode = new PriorityNode<T>(key, data);
        PriorityNode<T> temp = null;
        PriorityNode<T> current = RootNode;

        var isUpdated = false;
        while (current != null)
        {
            current.AmountOfNode += 1;
            temp = current;

            if (current.Key.CompareTo(key) == 0)
            {
                newNode = current;
                isUpdated = true;
                break;
            }

            current = (newNode.Key.CompareTo(current.Key) == -1) ? current.Left : current.Right;
        }

        newNode.Neighbors.Add(data);

        if (isUpdated)
            return;

        newNode.Parent = temp;
        newNode.Left = null;
        newNode.Right = null;

        if (temp is null)
        {
            RootNode = newNode;
        }
        else
        {
            if (newNode.Key.CompareTo(temp.Key) == -1)
                temp.Left = newNode;
            else
                temp.Right = newNode;
        }
        Count++;
    }

    public T Dequeue()
    {
        var minimum = GetMinimumNode();

        var neighbors = minimum.Neighbors.GetEnumerator();
        neighbors.MoveNext();
        T current = neighbors.Current;
        if (current is not null)
        {
            minimum.Neighbors.Remove(current);
            if (minimum.Neighbors.Count == 0)
                Remove(minimum.Key);

            return current;
        }
        return default;
    }

    private PriorityNode<T> GetMinimumNode()
    {
        var current = RootNode;

        if (current is null)
            return null;

        while (current.Left is not null)
            current = current.Left;

        return current;
    }

    public void Remove(double key)
    {
        if (RootNode is null)
            return;

        PriorityNode<T> p;
        PriorityNode<T> r = null;
        PriorityNode<T> q = GetNode(key);
        q.AmountOfNode -= 1;

        if (q?.Left is null || q.Right is null)
        {
            r = q;
        }
        else
        {
            var temp = new PriorityNode<T>(r.Key, r.Value);
            temp.Parent = q.Parent;
            temp.Left = q.Left;
            temp.Right = q.Right;
            q = temp;
        }
        p = r.Left ?? r.Right;

        if (p is not null)
            p.Parent = r.Parent;

        if (r.Parent is null)
        {
            RootNode = p;
        }
        else
        {
            if (r == r.Parent.Left)
                r.Parent.Left = p;
            else
                r.Parent.Right = p;
        }
        r = null;

        Count--;
    }

    public PriorityNode<T> GetNode(double key)
    {
        PriorityNode<T> p = RootNode;
        while (p != null)
        {
            if (p.Key.CompareTo(key) == 0)
                return p;

            p = (key.CompareTo(p.Key) == -1) ? p.Left : p.Right;
        }

        return null;
    }
}