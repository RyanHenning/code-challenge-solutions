public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, bool> map = new Dictionary<int, bool>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], false);
            }
            else if (map[nums[i]] == false)
            {
                map[nums[i]] = true;
            }
        }
        
        return map.FirstOrDefault(kvp => kvp.Value == false).Key;
    }
}