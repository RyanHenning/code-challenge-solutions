namespace datastructures.tree
{
    public class tree
    {
        public Node root = new Node();

        public Node Traverse(Node current)
        {
            if (current == null)
            {
                return;
            }

            foreach(Node child in current.children)
            {
                Traverse(child);
            }
        }
    }

    public class Node 
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val,IList<Node> _children) 
        {
            val = _val;
            children = _children;
        }
    }
}