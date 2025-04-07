namespace LeetCode.CSharp._0000_0999._0400_0499
{
    /// <summary>
    /// <para>443</para>
    /// <para>https://leetcode.com/problems/string-compression/description/?envType=study-plan-v2&amp;envId=leetcode-75</para>
    /// </summary>
    public class StringCompression
    {

        public static int Process(char[] chars)
        {
            int posToReplace = 0, len = chars.Length;
            for (int i = 0, j = i + 1; i < len;)
            {
                while (j < len && chars[j] == chars[i])
                {
                    ++j;
                }

                chars[posToReplace++] = chars[i];

                if(j - i > 1)
                {
                    string charCount = $"{j - i}";
                    foreach(var cc in charCount)
                    {
                        chars[posToReplace++] = cc;
                    }
                }
                i = j;
            }

            return posToReplace;
        }
    }
}
