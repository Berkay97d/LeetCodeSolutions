using System;

namespace LeetCodeSolutions._0066_Plus_One
{
    public class Solution
    {
        public static int[] PlusOne(int[] digits) 
        {
            if (digits.Length == 1 && digits[0] == 9)
            {
                int[] r = new int[] { 1, 0 };
                return r;
            }
            
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }

            digits[digits.Length - 1] = 0;
            if (digits.Length != 1)
            {
                digits[digits.Length - 2] += 1;   
            }
            
            for (int i = digits.Length-1; i > 0; i--)
            {
                if (digits[i] == 10)
                {
                    digits[i] = 0;
                    digits[i - 1] += 1;
                    i = digits.Length-1;
                }
            }

            if (digits[0] != 10)
            {
                return digits;
            }

            var newArray = new int[digits.Length + 1];       

            for (int i = 2; i < newArray.Length; i++)
            {
                newArray[i] = digits[i - 1];
            }

            newArray[0] = 1;
            newArray[1] = 0;

            return newArray;
        }
    }
}