using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions._0026_Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        private static void Main()
        {
            int[] nums = new[] {0,0,0,0,0,0,0,0,0,0,1, 2, 3, 4, 5, 6,6};
        }

        
        private static int RemoveDuplicates(int[] nums)         //BRUT-FORCE USED, IMPROVE IT !!!
        {
            List<int> newNums = new List<int>();

            foreach (var num in nums)
            {
                if (!newNums.Contains(num))
                {
                    newNums.Add(num);
                }
            }

            for (int i = 0; i < newNums.Count; i++)
            {
                nums[i] = newNums[i];
            }
            
            return newNums.Count;
        }
    }
}