namespace LeetCodeSolutions._0001_Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int currentNumber, newTarget;
            int[] result = new int[2];
            
            for (int i = 0; i < nums.Length; i++)
            {
                currentNumber = nums[i];
                newTarget = target - currentNumber;

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] == newTarget)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return result;
        }
        
        
        
        
        
    }
}