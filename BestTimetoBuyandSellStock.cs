public class Solution {
    public int MaxProfit(int[] prices) {
        var lowest = prices.Min();
        var lowestIndex = Array.IndexOf(prices,lowest);      

        if(lowestIndex == prices.Length -1)  
            return 0;

        var largest = 0;
        var largestIndex = 0;

        for(int i = lowestIndex; i < prices.Length; i++)
        {
            if(prices[i] > largest){
                largest = prices[i];
                largestIndex = i;
            }
        }

        return (prices[largestIndex] - prices[lowestIndex]);
    }    
}
