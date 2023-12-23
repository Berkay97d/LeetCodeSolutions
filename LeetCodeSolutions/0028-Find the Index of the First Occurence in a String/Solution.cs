using System;
using System.Diagnostics;

namespace LeetCodeSolutions._0028_Find_the_Index_of_the_First_Occurence_in_a_String
{
    public class Solution 
    {
        
        private int StrStr(string haystack, string needle)
        {
            var counter = 0;
            
            for (int i = 0; i < haystack.Length; i++)         
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if(haystack[i] != needle[j])
                    {
                        i -= counter;
                        counter = 0;
                        break;
                    }
                    
                    if (i>=haystack.Length)
                    {
                        return -1;
                    }
                    
                    if (haystack[i] == needle[j])
                    {
                        counter++;
                        i++;
                    }

                    if (counter == needle.Length)
                    {
                        return i - needle.Length;
                    }
                }
            }

            return -1;
        }
    }
}