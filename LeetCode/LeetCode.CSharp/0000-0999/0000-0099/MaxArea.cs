using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._0000_0999._0000_0099
{
    /// <summary>
    /// <para>11</para>
    /// <para>https://leetcode.com/problems/container-with-most-water/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// <para>https://www.code-recipe.com/post/container-with-most-water</para>
    /// </summary>
    public class MaxArea
    {
        public static int Process(int[] height)
        {
            int hLen = height.Length;
            int right = hLen - 1, left = 0;
            var result = 0;

            while (left < right)
            {
                int hLeft = height[left], hRight = height[right];
                var currentArea = Math.Min(hLeft, hRight) * (right - left);

                result = Math.Max(result, currentArea);

                if (hLeft < hRight)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}
