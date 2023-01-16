using System;
using System.Collections.Generic;

namespace LeetCodeSolutions._0349__Intersection_of_Two_Arrays
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j] && !result.Contains(nums1[i]))
                    {
                        result.Add(nums1[i]);
                    }
                }
            }
            
            int[] finalResults = new int[result.Count];

            for (int i = 0; i < result.Count; i++)
            {
                finalResults[i] = result[i];
            }

            return finalResults;
        }
    }
}