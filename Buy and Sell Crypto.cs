public class Solution {
    public int MaxProfit(int[] prices)
    {
        int max = 0, min = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            int current = prices[i];
            min = Math.Min(min, current);
            max = Math.Max(max, current-min);
        }
        return max;
    }
    
}
