public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
        IList<int> previousRow = new List<int>();
        for (int i = 0; i < numRows; i++)
        {
            IList<int> currentRow = new List<int>();
            
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {   
                    currentRow.Add(1);
                }
                else
                {
                    currentRow.Add(previousRow[j-1] + previousRow[j]);
                }
            }
            
            result.Add(currentRow);
            previousRow = currentRow;
        }
        
        return result;
    }
}