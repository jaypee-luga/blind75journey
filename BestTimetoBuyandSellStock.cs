public class Solution {
    public int MaxProfit(int[] prices) {
        Dictionary<int, int> maxProfitMatrix = new Dictionary<int, int>();
        for (int y = 0; y < prices.Length; y++)
        {
            if(maxProfitMatrix.ContainsKey(prices[y]))
                continue;

            maxProfitMatrix.Add(prices[y], 0);

            for (int x = y; x < prices.Length; x++)
            {
                if (prices[x] - prices[y] > maxProfitMatrix[prices[y]])
                {
                    maxProfitMatrix[prices[y]] = prices[x] - prices[y];
                }
            }

        }

        return maxProfitMatrix.Values.Max();
    }    
}
