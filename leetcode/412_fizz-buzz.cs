public class Solution {
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";
    
    public IList<string> FizzBuzz(int n) {
        IList<string> result = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            int numberToAdd = i + 1;
            bool useFizz = numberToAdd % 3 == 0;
            bool useBuzz = numberToAdd % 5 == 0;
            
            if (useFizz && useBuzz)
                result.Add(Fizz+Buzz);
            else if (useFizz)
                result.Add(Fizz);
            else if (useBuzz)
                result.Add(Buzz);
            else
                result.Add(numberToAdd.ToString());
        }
        
        return result;
    }
}