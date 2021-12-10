using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[4][];
            matrix[0] = new int[] { 1, 2, 3, 4 };
            matrix[1] = new int[] { 5, 6, 7, 8 };
            matrix[2] = new int[] { 9, 10, 11, 12 };
            matrix[3] = new int[] { 13, 14, 15, 16 };

            RotateMatrix(matrix, 2);
        }

        static void RotateMatrix(int[][] matrix, int r)
        {

            var newMatrix = new int[matrix.Length][];
            for(int i =0; i< newMatrix.Length; i++)
            {
                newMatrix[i] = new int[matrix[0].Length];
            }
            
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    newMatrix[i][j] = matrix[i][j];
                    
                }
                
            }
        }
       
    }
}