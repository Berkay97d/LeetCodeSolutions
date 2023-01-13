namespace LeetCodeSolutions._0026_Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int counter = 0;
            
            for (int i = 0; i < nums.Length/2; i++)
            {
                if (nums[i] == nums[i+1])
                {
                    nums[i] = -101;
                }

                if (nums[nums.Length - (i+1)] == nums[nums.Length - (i+2)])
                {
                    nums[nums.Length - (i + 1)] = -101;
                }
            }

            foreach (var num in nums)
            {
                if (num != -101)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}