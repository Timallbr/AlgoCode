using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._0000_0999._0100_0199
{
    /// <summary>
    /// <para>151</para>
    /// <para>https://leetcode.com/problems/reverse-words-in-a-string/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class ReverseWords
    {
        public static string Process(string s)
        {
            var wordArr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int start = 0, end = wordArr.Length - 1;

            while (start < end)
            {
                var temp = wordArr[start];
                wordArr[start] = wordArr[end];
                wordArr[end] = temp;
                start++;
                end--;
            }

            return string.Join(' ', wordArr);
        }
    }
}
