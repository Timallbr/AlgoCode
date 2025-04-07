using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp._0000_0999._0000_0099
{
    /// <summary>
    /// <para>70</para>
    /// <para>https://leetcode.com/problems/climbing-stairs/description/</para>
    /// </summary>
    public class ClimbingStairs
    {
        public static int ProcessRecursion(int n)
        {
            return DepthFirstSearch(n, 0);
        }

        private static int DepthFirstSearch(int n, int i)
        {
            if (i >= n) return i == n ? 1 : 0;
            return DepthFirstSearch(n, i + 1) + DepthFirstSearch(n, i + 2);
        }

        int[] cache;
        public int ProcessDpTopDown(int n)
        {
            cache = new int[n];
            for (int i = 0; i < n; i++)
            {
                cache[i] = -1;
            }
            return TopDown(n, 0);
        }

        private int TopDown(int n, int i)
        {
            if (i >= n) return i == n ? 1 : 0;
            if (cache[i] != -1) return cache[i];
            return cache[i] = TopDown(n, i + 1) + TopDown(n, i + 2);
        }


        public int ProcessDpBottomUp(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

        public int ProcessDpSpaceOptimized(int n)
        {
            int one = 1, two = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int temp = one;
                one = one + two;
                two = temp;
            }

            return one;
        }

        public int ProcessMatrixOptimization(int n)
        {
            if (n == 1) return 1;

            int[,] M = new int[,] { { 1, 1 }, { 1, 0 } };
            int[,] result = MatrixPow(M, n);

            return result[0, 0];
        }

        private int[,] MatrixMult(int[,] A, int[,] B)
        {
            return new int[,] {
            {A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0],
             A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1]},
            {A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0],
             A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1]}
        };
        }

        private int[,] MatrixPow(int[,] M, int p)
        {
            int[,] result = new int[,] { { 1, 0 }, { 0, 1 } };
            int[,] baseM = M;

            while (p > 0)
            {
                if (p % 2 == 1)
                {
                    result = MatrixMult(result, baseM);
                }
                baseM = MatrixMult(baseM, baseM);
                p /= 2;
            }

            return result;
        }

        public int ProcessMath(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double phi = (1 + sqrt5) / 2;
            double psi = (1 - sqrt5) / 2;
            n++;
            return (int)Math.Round((Math.Pow(phi, n) -
                         Math.Pow(psi, n)) / sqrt5);
        }
    }
}
