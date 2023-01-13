namespace LeetCodeSolutions._0136_Single_Number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int index = 0;
            int uniqueNum;     

            for (int i = 0; i < nums.Length; i++) 
            {
                uniqueNum = nums[index];
                
                if (index == i)
                {
                    continue;
                }
                
                if (uniqueNum == nums[i])
                {
                    index++;
                    i = -1;
                }
            }

            return nums[index]; 
        }
    }
}