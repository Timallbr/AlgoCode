using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CSharp.OneWeek.DayTwo
{
    public class FlipTheMatrix
    {
        public static int Process(List<List<int>> matrix)
        {
            int length = matrix.Count;
            int halfLength = length / 2;
            length--;
            int sum = 0;

            for (int i = 0; i < halfLength; i++)
            {
                for (int j = 0; j < halfLength; j++)
                {
                    int topLeft = matrix[i][j];
                    int topRight = matrix[i][length - j];
                    int bottomLeft = matrix[length - i][j];
                    int bottomRight = matrix[length - i][length - j];

                    int[] mirror = { topLeft, topRight, bottomLeft, bottomRight };
                    sum += mirror.Max();
                }
            }

            return sum;
        }
    }
}
