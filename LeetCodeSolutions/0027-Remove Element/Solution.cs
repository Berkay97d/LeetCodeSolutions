namespace LeetCodeSolutions._0027_Remove_Element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var countOfNonVolNumber = 0;
            
            foreach (var num in nums)
            {
                if (num != val)
                {
                    countOfNonVolNumber++;
                }
            }
            
            int[] nonVolNumberIndexes = new int[countOfNonVolNumber];
            var counter = 0;
            
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num != val)
                {
                    nonVolNumberIndexes[counter] = nums[i];
                    counter++;
                }
            }

            for (int i = 0; i < nonVolNumberIndexes.Length; i++)
            {
                nums[i] = nonVolNumberIndexes[i];
            }

            return countOfNonVolNumber;
        }
    }
}