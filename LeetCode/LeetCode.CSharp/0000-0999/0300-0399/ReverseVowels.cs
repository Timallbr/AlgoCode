
namespace LeetCode.CSharp._0000_0999._0300_0399
{
    /// <summary>
    /// <para>345</para>
    /// <para>https://leetcode.com/problems/reverse-vowels-of-a-string/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class ReverseVowels
    {
        public static string Process(string s)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var vowelIndexes = new List<int>();

            int start = 0, end = s.Length - 1;
            var charArr = s.ToCharArray();

            while (start < end)
            {
                while (start < end && vowels.Contains(charArr[start]) == false)
                {
                    start++;
                }

                while (start < end && vowels.Contains(charArr[end]) == false)
                {
                    end--;
                }

                if(start < end)
                {
                    var temp = charArr[start];
                    charArr[start] = charArr[end];
                    charArr[end] = temp;
                    start++;
                    end--;
                }
            }


            return new string(charArr);
        }
    }
}
