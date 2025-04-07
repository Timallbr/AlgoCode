using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CSharp.OneWeek.DayOne
{
    public class MinMaxSum
    {
        public static void Process(List<int> arr)
        {
            long smallest = int.MaxValue, largest = 0, sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
                sum += arr[i];
            }

            Console.WriteLine($"{sum - largest} {sum - smallest}");
        }
    }
}
