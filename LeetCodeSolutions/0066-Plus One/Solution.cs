namespace LeetCodeSolutions._0066_Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits) 
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }
            
            //TODO son eleman 9 ise, devretme mantığını ekleyelim
            return digits;
        }
    }
}