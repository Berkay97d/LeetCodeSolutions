using System;

namespace LeetCodeSolutions._0009_Palindrome_Number
{
    public class Solution {
        private static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;

            int digitCount;
            long digitChecker = 10;     //using long because if int x > int32.max digit checker be greater than int32.max    
            
            while (true)
            {
                if (x / digitChecker >= 1)
                {
                    digitChecker *= 10;
                    continue;
                }

                digitCount = (int) Math.Log10(digitChecker);
                break;
            }

            int[] digits = new int[digitCount];
            

            for (int i = digitCount-1 ; i >= 0; i--)
            {
                var numInStr = x.ToString();
                var digit = int.Parse(numInStr[i].ToString());

                digits[i] = digit;
            }

            if (digitCount % 2 == 0)
            {
                for (int i = 0; i < (digitCount/2); i++)
                {
                    if (digits[i] == digits[digits.Length- 1 - i])
                    {
                       continue; 
                    }

                    return false;
                }
            }
            else
            {
                for (int i = 0; i < (digitCount-1/2); i++)
                {
                    if (digits[i] == digits[digits.Length- 1 - i])
                    {
                        continue; 
                    }

                    return false;
                }    
            }
            
            return true;
        }
    }
}