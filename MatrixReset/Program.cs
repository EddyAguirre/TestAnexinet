using System;
using System.Collections.Generic;

namespace MatrixReset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificar matriz para comprobar funcionalidad
            int[,] matrix =
                {
                   {1,2,3,4,5,0},
                   {1,2,3,0,1,2},
                   {1,2,3,4,5,6},
                   {1,2,3,4,5,6},
                   {1,2,3,4,5,6},
                   {1,2,3,4,5,6},
                   {1,2,3,4,5,6},
                   {1,0,3,4,5,6}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i, j]} ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            matrix = MatrixSearcher(matrix);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($" {matrix[i, j]} ");

                Console.Write("]");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Search for 0 in the matrix and set row and column to 0
        /// </summary>
        /// <param name="matrix">Matrix to search for 0</param>
        /// <returns></returns>
        public static int[,] MatrixSearcher(int[,] matrix)
        {
            List<KeyValuePair<int, int>> indexList = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == 0)
                        indexList.Add(new KeyValuePair<int, int>(i, j));

            }
            return MatrixReset(matrix, indexList);
        }

        /// <summary>
        /// Set to 0 rows and columns from the list
        /// </summary>
        /// <param name="matrix">Matrix to set</param>
        /// <param name="indexList">List of index for every cell with cero</param>
        /// <returns></returns>
        public static int[,] MatrixReset(int[,] matrix, List<KeyValuePair<int, int>> indexList)
        {
            foreach (var item in indexList)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    matrix[i, item.Value] = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[item.Key, j] = 0;
            }
            return matrix;
        }

    }
}
