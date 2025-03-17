
namespace LeetCode.CSharp._1000_1099
{
    public class GcdOfStrings
    {
        public static string Process(string str1, string str2)
        {
            var result = "";
            if (str1 + str2 != str2 + str1)
            {
                return result;
            }

            int gcdLength = GreatestCommonDenominator(str1.Length, str2.Length);

            result = str1.Substring(0, gcdLength);

            return result;
        }

        private static int GreatestCommonDenominator(int a, int b)
        {
            var result = b == 0 ? a : GreatestCommonDenominator(b, a % b);

            return result;
        }
    }
}
