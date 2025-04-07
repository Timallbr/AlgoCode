namespace LeetCode.CSharp._0000_0999._0200_0299
{
    /// <summary>
    /// <para>283</para>
    /// <para>https://leetcode.com/problems/move-zeroes/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class MoveZeroes
    {
        public static void Process(int[] nums)
        {
            int posToSwitch = 0, len = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if(nums[i] != 0)
                {
                    var num = nums[i];
                    nums[i] = nums[posToSwitch];
                    nums[posToSwitch++] = num;
                }
            }
        }
    }
}
