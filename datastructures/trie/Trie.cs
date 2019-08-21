using System.Collections.Generic;

namespace datastructures.trie
{
    public class TrieNode
    {
        public char Val { get; private set; }
        public List<TrieNode> Children { get; set; }
        public TrieNode Parent { get; private set; }
        public int Depth { get; private set; }

        public bool IsLeaf 
        { 
            get 
            {
                return Children.Count == 0 ? true : false;
            }
        }
        
        public TrieNode (char val, int depth, TrieNode parent)
        {
            Val = val;
            Depth = depth;
            Parent = parent;
            Children = new List<TrieNode>();
        }

        public TrieNode FindChildNode(char c)
        {
            for (int i=0; i < this.Children.Count; i++)
            {
                if (this.Children[i].Val == c)
                    return this.Children[i];
            }

            return null;
        }

        public bool DeleteChild(char c)
        {
            for (int i=0; i < this.Children.Count; i++)
            {
                if (this.Children[i].Val == c)
                {
                    this.Children.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
    public class Trie
    {
        private readonly TrieNode _root;
        public Trie()
        {
            _root = new TrieNode('^', 0, null);    
        }

        // returns the prefix of the string that is already in the Trie
        public TrieNode Prefix(string s)
        {
            var currentNode = _root;
            var result = currentNode;

            foreach (char c in s)
            {
                currentNode = currentNode.FindChildNode(c);
                if (currentNode == null)
                {
                    break;
                }

                result = currentNode;
            }

            return result;
        }
        
        // Returns true if input string exists entirely in the Trie
        public bool Search(string s)
        {
            var prefix = Prefix(s);
            return prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
        }

        public void InsertRange(List<string> strings)
        {
            foreach (string s in strings)
            {
                InsertSingleString(s);
            }
        }

        public void InsertSingleString(string s)
        {
            var existingPrefix = Prefix(s);

            var current = existingPrefix;

            for (int i = current.Depth; i < s.Length; i++)
            {
                var newNode = new TrieNode(s[i], current.Depth+1, current);
                current.Children.Add(newNode);
                current = newNode;
            }

            current.Children.Add(new TrieNode('$', current.Depth + 1, current));
        }

        public void Delete(string s)
        {
            if (!Search(s))
            {
                return;
            }

            var node = Prefix(s).FindChildNode('$');

            while (node.IsLeaf)
            {
                var parent = node.Parent;
                parent.DeleteChild(node.Val);
                node = parent;
            }
        }
    }

}