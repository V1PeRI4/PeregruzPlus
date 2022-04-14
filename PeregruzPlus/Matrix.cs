using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeregruzPlus
{
    internal class Matrix
    {
        private double[,] values;

        public Matrix(int columns, int rows)
        {
            Columns = columns;
            Rows = rows;

            values = new double[Rows, Columns];
        }

        public int Columns { get; set; }
        public int Rows { get; set; }
        public double[,] Values { get => values; set => values = value; }

        public void PrintMatrix()
        {
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                    Console.Write($"{values[i, j]}\t");
                Console.WriteLine();
            }
            PrintLine();
            
        }
        public void InitRndmValues()
        {
            Random random = new Random();

            for (int i = 0; i < values.GetLength(0); i++)
                for (int j = 0; j < values.GetLength(1); j++)
                    Values[i, j] = random.Next(1, 10);
        }
        
        public static Matrix operator +(Matrix matrix, Matrix matrix1)
        {
            int maxRow = matrix.Rows > matrix1.Rows ? matrix.Rows : matrix1.Rows;
            int maxColumn = matrix.Columns > matrix1.Columns ? matrix.Columns: matrix1.Columns;
            Matrix resultMatrix = new Matrix(maxColumn, maxRow);

            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    resultMatrix.Values[i, j] += matrix.Values[i, j];

            for (int i = 0; i < matrix1.Rows; i++)
                for (int j = 0; j < matrix1.Columns; j++)
                    resultMatrix.Values[i, j] += matrix1.Values[i, j];

            return resultMatrix;
        }

        private void PrintLine()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
