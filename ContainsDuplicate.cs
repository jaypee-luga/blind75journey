public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> matrix = new Dictionary<int, int>();
        foreach(var n in nums)
        {
            if(matrix.ContainsKey(n))
            {
                return true;
            }                
            else
            {
               matrix.Add(n,1); 
            }
        }
        return false;
    }
}
