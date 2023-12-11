using System.Collections.Generic;

namespace LeetCodeSolutions._0013_Roman_to_Integer
{
    public class Solution 
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>()
            {  
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
                
            };
            
            int result = dictionary[s[s.Length-1]];
            
            for(int i = s.Length - 2; i >= 0 ; i--)
            {
                if(dictionary[s[i]]<dictionary[s[i+1]])
                {
                    result -=dictionary[s[i]];
                }
                else
                {
                    result +=dictionary[s[i]];
                }
            }
            
            return result;
        }
        
    }
    
}