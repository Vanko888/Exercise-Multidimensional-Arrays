using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new double[input.Length];
                for (int j = 0; j < input.Length; j++)
                {

                    matrix[i][j] = input[j];
                }
            }
            for (int k = 0; k < matrix.GetLength(0) - 1; k++)
            {
                int indexOne = matrix[k].Length;
                int indexTwo = matrix[k + 1].Length;
                if (indexOne == indexTwo)
                {
                    for (int l = 0; l < indexOne; l++)
                    {
                        matrix[k][l] = matrix[k][l] * 2;
                        matrix[k + 1][l] = matrix[k + 1][l] * 2;
                    }
                }
                else
                {
                    for (int l = 0; l < indexOne; l++)
                    {
                        matrix[k][l] = matrix[k][l] / 2;
                    }
                    for (int m = 0; m < indexTwo; m++)
                    {
                        matrix[k + 1][m] = matrix[k + 1][m] / 2;
                    }
                }
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (command[0] == "Add")
                {
                    if (row < n && row >= 0 && col >= 0)
                    {
                        if (col < matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }

                    }

                }
                else if (command[0] == "Subtract")
                {
                    if (row < n && row >= 0 && col >= 0)
                    {
                        if (col < matrix[row].Length)
                        {
                            matrix[row][col] -= value;
                        }

                    }
                }
                command = Console.ReadLine().Split();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(string.Join(" ", matrix[i]));
                Console.WriteLine();
            }
        }
    }
}
