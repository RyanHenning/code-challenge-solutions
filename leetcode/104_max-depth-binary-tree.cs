public class TreeNode 
{
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
 }

public class Solution 
{
    
    public int MaxDepth(TreeNode root) {
        
        return Traverse(root, 1);
    }
    
    public int Traverse(TreeNode currentNode, int currentDepth)
    {
        if (currentNode == null)
        {
            return 0;
        }
        
        return Max(Traverse(currentNode.left, currentDepth), Traverse(currentNode.right, currentDepth)) + 1;
        
    }
    
    public int Max(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}