using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CSharp.OneWeek.DayTwo
{
    public class CountingSort
    {
        public static List<int> Process(List<int> arr)
        {
            var countArr = new int[arr.Count];

            foreach (int num in arr)
            {
                if(num < 100 && num >= 0)
                {
                    countArr[num]++;
                }
            }

            var countList = countArr.ToList();
            return countList;
        }
    }
}
