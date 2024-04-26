using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Multiplication
{
    internal class Matrix
    {
        private int[,] matrix;

        public Matrix(int height, int width)
        {
            matrix = new int[height, width];
        }

        public int this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return matrix.GetLength(1); }
        }
        public int[] GetRow(int row)
        {
            if (row >= 0 && row < Rows)
            {
                int[] result = new int[Columns];
                for (int col = 0; col < Columns; col++)
                {
                    result[col] = matrix[row, col];
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid row index.");
            }
        }

        public int[] GetColumn(int col)
        {
            if (col >= 0 && col < Columns)
            {
                int[] result = new int[Rows];
                for (int row = 0; row < Rows; row++)
                {
                    result[row] = matrix[row, col];
                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid column index.");
            }
        }

        public static implicit operator int[,](Matrix matrix)
        {
            return matrix.matrix;
        }

        public static string GetMatrixString(Matrix matrix)
        {
            int rows = matrix.matrix.GetLength(0);
            int columns = matrix.matrix.GetLength(1);
            string matrixString = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixString += matrix[i, j] + "\t";
                }
                matrixString += "\n";
            }
            matrixString += "\n";
            return matrixString;
        }

        public void Initialize()
        {
            Random random = new();
            Parallel.For(0, matrix.GetLength(0), i =>
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            });
        }
    }

}
