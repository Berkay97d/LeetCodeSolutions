﻿using System;

namespace LeetCodeSolutions._0035_Search_Insert_Position
{
    public class Solution
    {
       
        
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i] || nums[i] > target)
                {
                    return i;
                }
            }
            return nums.Length;
        }

    }
}