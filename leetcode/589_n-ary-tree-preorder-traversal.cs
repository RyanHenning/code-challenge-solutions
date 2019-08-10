/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    
    private IList<int> result = new List<int>();
    
    public IList<int> Preorder(Node root) {
        
        Traverse(root);
        
        return result;
    }
    
    private void Traverse(Node root)
    {
        if (root == null)
        {
            return;
        }    
        
        result.Add(root.val);
        
        foreach(Node child in root.children)
        {
            Traverse(child);
        }
    }
}