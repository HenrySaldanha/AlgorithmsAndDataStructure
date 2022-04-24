namespace DataStructure.Tree.AVL
{
    public class AVL
    {
        public AVLNode Root { get; private set; }

        public AVL Add(int value)
        {
            Root = Add(Root, value);

            return this;
        }

        public AVLNode Add(AVLNode node, int value)
        {
            if (node is null)
                return new AVLNode(value);

            if (value < node.Value)
                node.LeftNode = Add(node.LeftNode, value);
            else if (value > node.Value)
                node.RightNode = Add(node.RightNode, value);
            else
                return node;

            node.Height = Max(Height(node.LeftNode), Height(node.RightNode)) + 1;

            var balance = BalancingFactor(node);

            if (balance > 1 && value < node.LeftNode.Value)
                return RightRotate(node);

            if (balance < -1 && value > node.RightNode.Value)
                return LeftRotate(node);

            if (balance > 1 && value > node.LeftNode.Value)
            {
                node.LeftNode = LeftRotate(node.LeftNode);
                return RightRotate(node);
            }

            if (balance < -1 && value < node.RightNode.Value)
            {
                node.RightNode = RightRotate(node.RightNode);
                return LeftRotate(node);
            }
            return node;
        }

        public AVLNode Search(int value)
        {
            return Search(value, Root);
        }

        public AVLNode Search(int value, AVLNode node)
        {
            if (node is null)
                return null;

            if (value == node.Value)
                return node;
            else if (value < node.Value)
                return Search(value, node.LeftNode);
            else if (value > node.Value)
                return Search(value, node.RightNode);

            return null;
        }

        public AVL Remove(int value)
        {
            if (Root is null)
                return this;

            Root = Remove(Root, value);

            return this;
        }

        public AVLNode Remove(AVLNode node, int value)
        {
            if (node is null)
                return null;

            if (value < node.Value)
            {
                node.LeftNode = Remove(node.LeftNode, value);
            }
            else if (value > node.Value)
            {
                node.RightNode = Remove(node.RightNode, value);
            }
            else
            {
                if (node.LeftNode is null || node.RightNode is null)
                {
                    var temp = (node.LeftNode is not null) ? node.LeftNode : node.RightNode;
                    node = temp;
                }
                else
                {
                    var temp = MinNode(node.RightNode);
                    node.Value = temp.Value;
                    node.RightNode = Remove(node.RightNode, temp.Value);
                }
            }

            if (node is null)
                return null;

            node.Height = Max(Height(node.LeftNode), Height(node.RightNode)) + 1;

            var balance = BalancingFactor(node);

            if (balance > 1 && BalancingFactor(node.LeftNode) >= 0)
                return RightRotate(node);

            if (balance > 1 && BalancingFactor(node.LeftNode) < 0)
            {
                node.LeftNode = LeftRotate(node.LeftNode);
                return RightRotate(node);
            }

            if (balance < -1 && BalancingFactor(node.RightNode) <= 0)
                return LeftRotate(node);

            if (balance < -1 && BalancingFactor(node.RightNode) > 0)
            {
                node.RightNode = RightRotate(node.RightNode);
                return LeftRotate(node);
            }

            return node;
        }

        private int Height(AVLNode node) => (node is null) ? 0 : node.Height;
        private int BalancingFactor(AVLNode node) => Height(node.LeftNode) - Height(node.RightNode);
        private int Max(int a, int b) => a > b ? a : b;

        AVLNode MinNode(AVLNode node)
        {
            var current = node;

            while (current.LeftNode is not null)
                current = current.LeftNode;

            return current;
        }

        private AVLNode RightRotate(AVLNode node)
        {
            var left = node.LeftNode;
            var right = left.RightNode;

            left.RightNode = node;
            node.LeftNode = right;

            node.Height = Max(Height(node.LeftNode), Height(node.RightNode)) + 1;
            left.Height = Max(Height(left.LeftNode), Height(left.RightNode)) + 1;

            return left;
        }

        private AVLNode LeftRotate(AVLNode node)
        {
            var right = node.RightNode;
            var left = right.LeftNode;

            right.LeftNode = node;
            node.RightNode = left;

            node.Height = Max(Height(node.LeftNode), Height(node.RightNode)) + 1;
            right.Height = Max(Height(right.LeftNode), Height(right.RightNode)) + 1;

            return right;
        }
    }
}
