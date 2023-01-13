using System;
using System.Collections.Generic;

namespace LeetCodeSolutions._0069_Sqrt_x_
{
    public class Solution
    {
        public static int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            
            if (x == 1 || x == 2)
            {
                return 1;
            }
            
            List<int> sqrtList = new List<int>();  

            var max = Convert.ToInt32(Math.Ceiling((decimal) x / 2));
            
            for (int i = 1; i <= max ; i++)
            {
                sqrtList.Add(i);
            }

            for (int i = 0; i < sqrtList.Count; i++)
            {
                if (sqrtList[i] * sqrtList[i] == x)
                {
                    return sqrtList[i];
                }
                
                if (sqrtList[i] * sqrtList[i] > x)
                {
                    return sqrtList[i - 1];
                } 
            }

            return sqrtList[sqrtList.Count]+1;
        }
    }
}