namespace LeetCodeSolutions._0014_Longest_Common_Prefix
{
    public class Solution
    {
        

        private string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) { return ""; }
            if (strs.Length == 1) { return strs[0]; }

            string shortestStr = strs[0];
            
            for (var i = 0; i < strs.Length; i++)
            {
                var str = strs[i];
                
                if (str.Length < shortestStr.Length)
                {
                    shortestStr = str;
                }
            }
            
            
            for (int i = 0; i < shortestStr.Length; i++)   
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (shortestStr[i] != strs[j][i])
                    {
                        return shortestStr.Substring(0, i);
                    }
                }
            }
            
            return shortestStr;
        }
    }
}