using System;
using System.Diagnostics;

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
            char[] extended;
            bool isALonger = false;
            
            if (a.Length > b.Length)
            {
                isALonger = true;
                
                extended = new char[a.Length];
                int diffWhenALonger = a.Length - b.Length;

                for (int i = 0; i < extended.Length; i++)
                {
                    if (i+1 <= diffWhenALonger)
                    {
                        extended[i] = '0';
                    }
                    else
                    {
                        extended[i] = b[i - diffWhenALonger];
                    }
                }
            }
            else
            {
                extended = new char[b.Length];
                int diffWhenBLonger = b.Length - a.Length;
                
                for (int i = 0; i < extended.Length; i++)
                {
                    if (i+1 <= diffWhenBLonger)
                    {
                        extended[i] = '0';
                    }
                    else
                    {
                        extended[i] = b[i - diffWhenBLonger];
                    }
                }
            }

            bool hasRemainig = false;
            char[] result = new char[extended.Length];
            
            if (isALonger)
            {
                for (int i = a.Length-1; i>= 0; i--)
                {
                    if (extended[i] == a[i]) //AYNI
                    {
                        if (hasRemainig) //ELDE VARSA
                        {
                            if (extended[i] == '1') // 1SE
                            {
                                result[i] = '1';
                                hasRemainig = true;
                            }
                            else // 0SA
                            {
                                result[i] = '1';
                                hasRemainig = false;
                            }
                        }
                        else //ELDE YOKSA
                        {
                            if (extended[i] == '1') // 1SE
                            {
                                result[i] = '0';
                                hasRemainig = true;
                            }
                            else // 0SA
                            {
                                result[i] = '0';
                                hasRemainig = false;
                            }
                        }
                    }
                    else //FARKLI
                    {
                        if (hasRemainig) //ELDE VARSA
                        {
                            result[i] = '0';
                        }
                        else //ELDE YOKSA
                        {
                            result[i] = '1';
                        }
                    }
                }
            }

            foreach (var c in result)
            {
                Console.Write(c);
            }
            return " ";
        }
    }
}