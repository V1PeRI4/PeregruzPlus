using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeregruzPlus;

namespace Homeworks
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(2, 5);
            Matrix matrix1 = new Matrix(2, 2);
            Matrix result;

            matrix.InitRndmValues();
            matrix1.InitRndmValues();

            Console.WriteLine("Матрица 1\n");
            matrix.PrintMatrix();

            Console.WriteLine("Матрица 2\n");
            matrix1.PrintMatrix();

            result = matrix + matrix1;

            Console.WriteLine("Результат сложения:\n");
            result.PrintMatrix();

            Console.ReadKey();
        }

        
    }
}

