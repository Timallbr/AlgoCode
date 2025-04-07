namespace LeetCode.CSharp._0000_0999._0200_0299
{
    /// <summary>
    /// <para>238</para>
    /// <para>https://leetcode.com/problems/product-of-array-except-self/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class ProductExceptSelf
    {
        public static int[] Process(int[] nums)
        { 
            var numsLength = nums.Length;
            var result = new int[numsLength];
            for (int i = 0, left = 1; i < numsLength; i++)
            {
                result[i] = left;
                left *= nums[i];
            }

            
            for (int i = numsLength - 1, right = 1; i >= 0; i--)
            {
                result[i] = result[i] * right;
                right = right * nums[i];
            }

            return result;
        }
    }
}
