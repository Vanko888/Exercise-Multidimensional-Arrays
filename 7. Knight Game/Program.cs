using System;

namespace _7._Knight_Game
{
    class Program
    {
        private static bool IsInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1) && col >= 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int removedKnights = 0;
            while (true)
            {
                int maxAttack = 0;
                int knightRow = 0;
                int knightCol = 0;


                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == '0')
                        {
                            continue;
                        }
                        int cuuAttack = 0;
                        //upLeft, upRight
                        if (IsInRange(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                        {
                            cuuAttack++;
                        }
                        if (IsInRange(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                        {
                            cuuAttack++;
                        }
                        //leftUp, leftDown
                        if (IsInRange(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                        {
                            cuuAttack++;
                        }
                        if (IsInRange(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                        {
                            cuuAttack++;
                        }
                        //downLeft, downRight
                        if (IsInRange(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                        {
                            cuuAttack++;
                        }
                        if (IsInRange(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                        {                                                                      
                            cuuAttack++;                                                       
                        }                                                                      
                        //rightUp, rightDown                                                   
                        if (IsInRange(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                        {                                                                      
                            cuuAttack++;                                                       
                        }                                                                      
                        if (IsInRange(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                        {
                            cuuAttack++;
                        }
                        if (cuuAttack > maxAttack)
                        {
                            maxAttack = cuuAttack;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    removedKnights++;
                    matrix[knightRow, knightCol] = '0';
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    break;
                }

            }

        }
    }
}
