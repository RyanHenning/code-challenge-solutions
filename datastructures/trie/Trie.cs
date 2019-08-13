using System.Collections.Generic;

namespace datastructures.trie
{
    public class TrieNode
    {
        public char Val { get; private set; }
        public List<TrieNode> Children { get; set; }
        public TrieNode Parent { get; private set; }
        public int Depth { get; private set; }
        
        public TrieNode (char val, int depth, TrieNode parent)
        {
            Val = val;
            Depth = depth;
            Parent = parent;
        }
    }
    public class Trie
    {
        public TrieNode root = new TrieNode('^');

        
    }

}