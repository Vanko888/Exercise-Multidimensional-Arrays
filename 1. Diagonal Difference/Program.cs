using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0;  col < n;  col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
            }
            int index = n;
            for (int i = 0; i < n; i++)
            {
                sum2 += matrix[i, index - 1];
                index--;
            }
            int sumTotal = Math.Abs(sum1 - sum2);
            Console.WriteLine(sumTotal);
        }
    }
}
