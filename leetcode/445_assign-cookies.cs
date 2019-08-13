public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        int kidsFed=0;
        int kidIterator = 0;
        int cookieIterator = 0;
        
        Array.Sort(g);
        Array.Sort(s);
        
        while (cookieIterator < s.Length && kidIterator < g.Length)
        {
            if (g[kidIterator] <= s[cookieIterator])
            {
                kidsFed++;
                kidIterator++;
            }

            cookieIterator++;
        }        
        return kidsFed;
    }
}