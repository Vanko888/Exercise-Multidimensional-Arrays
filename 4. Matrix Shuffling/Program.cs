using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[rowCols[0], rowCols[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            string currNumber;
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commands[0] != "END")
            {
                if (commands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (commands[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (int.Parse(commands[1]) >= matrix.GetLength(0) || int.Parse(commands[3]) >= matrix.GetLength(0))
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (int.Parse(commands[2]) >= matrix.GetLength(1) || int.Parse(commands[4]) >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    currNumber = matrix[int.Parse(commands[1]), int.Parse(commands[2])];
                    matrix[int.Parse(commands[1]), int.Parse(commands[2])] = matrix[int.Parse(commands[3]), int.Parse(commands[4])];
                    matrix[int.Parse(commands[3]), int.Parse(commands[4])] = currNumber;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }

                

                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            
        }
    }
}
