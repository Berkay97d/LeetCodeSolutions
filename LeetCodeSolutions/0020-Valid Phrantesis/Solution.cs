using System.Collections.Generic;

namespace LeetCodeSolutions._0020_Valid_Phrantesis
{
    public class Solution
    {

        public bool IsValid(string s)   
        {
            Dictionary<char, char> dictionary = new Dictionary<char, char>()
            {
                { ')', '('},
                { ']', '['},
                { '}', '{'}
            };
            
            Stack<char> openerStack = new Stack<char>();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.TryGetValue(s[i], out char value))
                {
                    if (openerStack.Count == 0)
                    {
                        return false;
                    }
                    
                    if (value != openerStack.Pop())
                    {
                        return false;   
                    }
                }
                
                else
                {
                    openerStack.Push(s[i]); 
                }    
            }
            
            return openerStack.Count == 0;
        }
    }
}

