using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._0600_0699
{
    /// <summary>
    /// <para>605</para>
    /// <para>https://leetcode.com/problems/can-place-flowers/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class CanPlaceFlowers
    {
        public static bool Process(int[] flowerbed, int n)
        {
            var fbLength = flowerbed.Length;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                var left = i == 0 ? 0 : flowerbed[i - 1];
                var right = i == fbLength - 1 ? 0 : flowerbed[i + 1];
                if(left + flowerbed[i] + right == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

            return n <= 0;
        }
    }
}
