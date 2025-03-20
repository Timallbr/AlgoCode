using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._1400_1499
{
    /// <summary>
    /// <para>1431</para>
    /// <para>https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class GreatestNumberOfCandies
    {
        public static IList<bool> Process(int[] candies, int extraCandies)
        {
            var result = new bool[candies.Length];

            var mostCandy = 0;

            foreach (var candy in candies)
            {
                if (candy >= mostCandy)
                    mostCandy = candy;
            }


            for (int i = 0; i < candies.Length; i++)
            {
                var candy = candies[i];
                var newCandyAmount = candy + extraCandies;

                result[i] = newCandyAmount >= mostCandy;
            }

            return result;
        }
    }
}
