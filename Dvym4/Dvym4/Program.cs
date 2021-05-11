using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym4
{
    class Program
    {
        const int MATRIX1_LINE = 5;
        const int MATRIX1_COLLUMN = 3;

        // По правилам умножения матрицы:
        // Матрицы A и B могут быть перемножены, если они совместимы в том смысле, что число столбцов матрицы A равно числу строк B.  
        const int MATRIX2_LINE = MATRIX1_COLLUMN;
        const int MATRIX2_COLLUMN = 3;

        static void Main(string[] args)
        {
            int[,] matrix1 = new int[MATRIX1_LINE, MATRIX1_COLLUMN];
            Random rnd = new Random();

            // Заполнение матрицы
            for (int i = 0; i < MATRIX1_LINE; i++)
            {
                for (int j = 0; j < MATRIX1_COLLUMN; j++)
                {
                    matrix1[i, j] = rnd.Next(-10, 11);
                }
            }

            int[,] matrix2 = new int[MATRIX1_LINE, MATRIX1_COLLUMN];

            // Заполнение матрицы
            for (int i = 0; i < MATRIX2_LINE; i++)
            {
                for (int j = 0; j < MATRIX2_COLLUMN; j++)
                {
                    matrix2[i, j] = rnd.Next(-10, 11);
                }
            }

            // Вывод матрицы
            Console.WriteLine("1 матрица: ");
            for (int i = 0; i < MATRIX1_LINE; i++)
            {
                for (int j = 0; j < MATRIX1_COLLUMN; j++)
                {
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("2 матрица: ");
            for (int i = 0; i < MATRIX2_LINE; i++)
            {
                for (int j = 0; j < MATRIX2_COLLUMN; j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }

            // Результирующая матрица имеет столькоже строк сколько 1 матрица, и столько же столбцов сколько и 2 матрица
            int[,] matrixResult = new int[MATRIX1_LINE, MATRIX2_COLLUMN];
            for (int i = 0; i < MATRIX1_LINE; i++)
            {
                for (int j = 0; j < MATRIX2_COLLUMN; j++)
                {
                    // Тут происходит МАГИЯ :)
                    // А если сложно, я хз как это  описать подробно, да и лень мне.
                    int r = 0;
                    for (int k = 0; k < MATRIX1_COLLUMN; k++)
                    {
                        r += matrix1[i, k] * matrix2[k, j];
                    }

                    matrixResult[i, j] = r;
                }
            }

            Console.WriteLine("Результат: ");
            for (int i = 0; i < MATRIX1_LINE; i++)
            {
                for (int j = 0; j < MATRIX2_COLLUMN; j++)
                {
                    Console.Write($"{matrixResult[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
