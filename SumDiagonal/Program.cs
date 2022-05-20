using System;
using System.Collections.Generic;

namespace SumDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<List<int>> { new List<int> { 1, 2, 3  }, new List<int> { 4, 5, 6 }, new List<int> { 9, 8, 9 } };

            Console.WriteLine(diagonalDifference(input));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int rows = 0, columns = 0, mainDiag = 0, secDiag = 0, total = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {


                    //Get the sum of the main diagonal
                    if (i == j)
                    {
                        mainDiag = mainDiag + arr[i][j];
                    }

                    //Get the sum of the second diagonal
                    if ((i + j) == (arr.Count - 1))
                    {
                        secDiag = secDiag + arr[i][j];
                    }
                }                               
            }

            total = mainDiag - secDiag;

            return Math.Abs(total);
        }
    }
}
