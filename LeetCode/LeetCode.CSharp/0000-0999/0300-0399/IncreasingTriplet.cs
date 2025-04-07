namespace LeetCode.CSharp._0000_0999._0300_0399
{
    /// <summary>
    /// <para>334</para>
    /// <para>https://leetcode.com/problems/increasing-triplet-subsequence/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class IncreasingTriplet
    {
        public static bool Process(int[] nums)
        {
            var numLength = nums.Length;
            int num1, num2 = num1 = Int32.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            { 
                var num = nums[i];

                if (num <= num1)
                    num1 = num;
                else if (num <= num2)
                    num2 = num;
                else
                    return true;
            }

            return false;
        }
    }
}
