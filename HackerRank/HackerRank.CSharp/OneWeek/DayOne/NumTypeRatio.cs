namespace HackerRank.CSharp.OneWeek.DayOne
{
    public class NumTypeRatio
    {
        public static void Process(List<int> arr)
        {
            var total = arr.Count;
            float posCount = 0, negCount = 0, zeroCount = 0;

            for (int i = 0; i < total; i++)
            {
                if (arr[i] == 0)
                {
                    zeroCount++;
                }
                else if (arr[i] > 0)
                {
                    posCount++;
                }
                else if (arr[i] < 0)
                {
                    negCount++;
                }
            }

            float posRatio = posCount / total;
            float negRatio = negCount / total;
            float zeroRatio = zeroCount / total;
            Console.WriteLine(string.Format("{0:0.000000}", posRatio));
            Console.WriteLine(string.Format("{0:0.000000}", negRatio));
            Console.WriteLine(string.Format("{0:0.000000}", zeroRatio));
        }
    }
}
