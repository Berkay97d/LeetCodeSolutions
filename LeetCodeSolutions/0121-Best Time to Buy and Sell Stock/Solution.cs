namespace LeetCodeSolutions._0121_Best_Time_to_Buy_and_Sell_Stock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)      //TODO Time Limit Exceeded
        {
            int bestProfit = 0;
            
            
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > bestProfit)
                    {
                        bestProfit = prices[j] - prices[i];
                    }
                }
            }

            return bestProfit;



        }
        
    }
}