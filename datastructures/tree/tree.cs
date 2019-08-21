namespace datastructures.tree
{
    using System.Collections.Generic;

    public class tree
    {
        
        public Node root = new Node();

        public string Traverse(Node current)
        {
            string downTreeSuffix = string.Empty;

            if (current == null)
            {
                return string.Empty;
            }

            foreach(Node child in current.children)
            {
                downTreeSuffix += Traverse(child);
            }

            return $"{current.val}{downTreeSuffix}";
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