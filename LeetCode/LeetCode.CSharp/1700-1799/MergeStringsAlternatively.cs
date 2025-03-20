using System.Text;

namespace LeetCode.CSharp._1700_1799
{
    /// <summary>
    /// <para>1768</para>
    /// <para>https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class MergeStringsAlternately
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int word1Length = word1.Length, word2Length = word2.Length;
            var sb = new StringBuilder();

            for (int i = 0; i < word1Length || i < word2Length; i++)
            {
                if(i < word1Length)
                {
                    sb.Append(word1[i]);
                }

                if (i < word2Length)
                {
                    sb.Append(word2[i]);
                }
            }
            var result = sb.ToString();
            return result;
        }
    }
}
