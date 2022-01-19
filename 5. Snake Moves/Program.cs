using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[] snake = Console.ReadLine().ToCharArray();
            Queue<char> currSnake = new Queue<char>();

            for (int i = 0; i < snake.Length; i++)
            {
                currSnake.Enqueue(snake[i]);
            }
            char[,] matrix = new char[input[0], input[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = currSnake.Peek();
                        currSnake.Enqueue(currSnake.Dequeue());
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) -1 ; col >= 0; col--)
                    {
                        matrix[row, col] = currSnake.Peek();
                        currSnake.Enqueue(currSnake.Dequeue());
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
