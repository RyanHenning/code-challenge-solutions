public class Solution {
    public void ReverseString(char[] s) {

        Queue<char> stack = new Queue<char>();
        for (int i = s.Length-1; i >= 0; i--)
        {
            stack.Enqueue(s[i]);
        }
        
        for (int j = 0; j < s.Length; j++)
        {
            s[j] = stack.Dequeue();
        }
    }
}