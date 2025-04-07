using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._0000_0999._0600_0699
{
    /// <summary>
    /// <para>643</para>
    /// <para>https://leetcode.com/problems/maximum-average-subarray-i/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class FindMaxAverage
    {
        public static double Process(int[] nums, int k)
        {
            var sum = 0;

            for(int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            var solution = sum;

            for(int i = k; i < nums.Length; i++)
            {

            }

            return solution;
        }
    }
}
