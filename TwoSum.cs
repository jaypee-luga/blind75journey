public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var hash = new Dictionary<int, short>();
        for(short index = 0; index <= nums.Length - 1; index++)
        {
            if(hash.ContainsKey(target - nums[index]))   
                return new int[] {index, hash[target - nums[index]]};
            hash.TryAdd(nums[index], index);
        }
        
        return default;
    }
}
