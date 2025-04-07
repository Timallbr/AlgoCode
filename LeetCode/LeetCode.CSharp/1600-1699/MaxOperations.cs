using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._1600_1699
{
    /// <summary>
    /// <para>1679</para>
    /// <para>https://leetcode.com/problems/max-number-of-k-sum-pairs/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class MaxOperations
    {
        public static int Process(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1, solutions = 0;

            while (left < right)
            {
                if(nums[left] + nums[right] < k)
                {
                    left++;
                }
                else if(nums[left] + nums[right] > k)
                {
                    right--;
                }
                else
                {
                    solutions++;
                    right--;
                    left++;
                }
            }


            return solutions;
        }

        public static int ProcessHashMap(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            int solutions = 0;
            
            foreach (var num in nums)
            {
                if(map.ContainsKey(k - num))
                {
                    ++solutions;

                    var value = map[k - num] -= 1;

                    if(value == 0)
                    {
                        map.Remove(k - num);
                    }
                }
                else
                {
                    if(map.ContainsKey(num))
                    {
                        map[num] += 1;
                    }
                    else
                    {
                        map.Add(num, 1);
                    }
                }
            }


            return solutions;
        }
    }
}
