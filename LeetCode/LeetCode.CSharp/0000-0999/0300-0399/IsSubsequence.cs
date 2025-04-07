namespace LeetCode.CSharp._0000_0999._0300_0399
{
    /// <summary>
    /// <para>392</para>
    /// <para>https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class IsSubsequence
    {
        public static bool Process(string s, string t)
        {
            var sArr = s.ToCharArray();
            var tArr = t.ToCharArray();
            int sPosToCheck = 0, tLen = tArr.Length, sLen = sArr.Length;
            for (int i = 0; i < tLen; i++)
            {
                var tChr = tArr[i];
                if (sArr[sPosToCheck] == tChr)
                {
                    sPosToCheck++;
                }

                if (sPosToCheck == sLen - 1)
                    return true;
            }

            return false;
        }

        /// LeetCode Java implementation using while loop
        //public boolean isSubsequence(String s, String t)
        //{
        //    int m = s.length(), n = t.length();
        //    int i = 0, j = 0;
        //    while (i < m && j < n)
        //    {
        //        if (s.charAt(i) == t.charAt(j))
        //        {
        //            ++i;
        //        }
        //        ++j;
        //    }
        //    return i == m;
        //}
    }
}
