using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CSharp.OneWeek.DayTwo
{
    public class DiagonalDifference
    {
        public static int Process(List<List<int>> arr)
        {
            var rowColumnCount = arr.Count;
            int left = 0, right = rowColumnCount - 1;
            int fromLeft = 0, fromRight = 0;
            foreach(var row in arr)
            {
                fromLeft += row[left];
                fromRight += row[right];
                left++;
                right--;
            }

            var result = Math.Abs(fromLeft - fromRight);

            return result;
        }
    }
}
