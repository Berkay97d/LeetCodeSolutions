using System;

namespace LeetCodeSolutions._0058__Length_of_Last_Word
{
    public class Solution
    {
        public static void Main()
        {
          Console.WriteLine(LengthOfLastWord(" "));
        }
        
        public static int LengthOfLastWord(string s) //ber kay  length 6    last eleman s[5]
        {
            int lastEmptyCount = 0;
            bool isLetterFound = false;

            for (int i = s.Length-1; i >= 0; i--)
            {
                if (!isLetterFound && s[i] == ' ')
                {
                    lastEmptyCount++;
                }
                
                if (s[i] == ' ')
                {
                    if (!isLetterFound)
                    {
                        continue;
                    }
                    
                    return (s.Length - 1) - i - lastEmptyCount;
                }
                else
                {
                    isLetterFound = true;

                    if (i-1 < 0 && lastEmptyCount != 0)
                    {
                        return 1;
                    }
                }
                
                if (i-1 < 0 && lastEmptyCount == 0)
                {
                    return s.Length;
                }
            }
            
            return 0;
        }

    }
    
}