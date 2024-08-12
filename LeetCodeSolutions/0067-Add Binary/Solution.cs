using System;
using System.Text;

namespace LeetCodeSolutions._0067_Add_Binary
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine(AddBinary("1010", "101"));
        }
        
        public static string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }
                
                carry = sum / 2;
                
                result.Append(sum % 2);
            }
            
            char[] resultArray = result.ToString().ToCharArray();
            Array.Reverse(resultArray);
            return new string(resultArray);
        }
    }
}