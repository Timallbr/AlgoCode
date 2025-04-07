using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CSharp.OneWeek.DayTwo
{
    public class LonelyInteger
    {
        public static int Process(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] += 1;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            return dict.FirstOrDefault(x => x.Value == 1).Key;
        }
    }
}
