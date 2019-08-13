using System.Collections.Generic;

namespace datastructures.trie
{
    public class TrieNode
    {
        public string Val { get; }
        public List<TrieNode> Children { get; set; } = new List<TrieNode>();

        public bool CompletesString { get; set;}
        public TrieNode (string val)
        {
            Val = val;
        }
    }
    public class Trie
    {
        public TrieNode root = new TrieNode(string.Empty);
    }

}