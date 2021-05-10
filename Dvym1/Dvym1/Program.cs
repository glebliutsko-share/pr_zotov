using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvym1
{
    class Program
    {
        const int MATRIX_LINE = 5;
        const int MATRIX_COLLUMN = 3;

        static void Main(string[] args)
        {
            // Инициализируем матрицу
            int[,] matrix = new int[MATRIX_LINE, MATRIX_COLLUMN];

            // Заполняем матрицу случайными числами
            Random rnd = new Random();
            for (int i = 0; i < MATRIX_LINE; i++)
            {
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                {
                    matrix[i, j] = rnd.Next(0, 6);
                }
            }

            // Выводим матрицу на консоль
            for (int i = 0; i < MATRIX_LINE; i++)
            {
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            // Ищем строки без нуля и максимальное число, встречающихся в матрице более 1 раза.

            /* В этом массиве будет хранится кол-во повторений каждого числа.
             * Т.к. возможных чисел всего 6 (0, 1, 2, 3, 4, 5), то и массив будет длиной в 6 элементов.
             * Значения элементов -- это количество повторений элемента.
             */
            int[] countNubers = new int[6] { 0, 0, 0, 0, 0, 0 };
            
            // Кол-во строк без 0
            int countLineNotContainsZero = 0;
            for (int i = 0; i < MATRIX_LINE; i++)
            {
                bool isContainsZero = false; // Содержит ли сторока 0
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                {
                    // Если в строке есть 0, то записываем true в isContainsZero
                    if (matrix[i, j] == 0) isContainsZero = true;
                    
                    countNubers[matrix[i, j]]++;
                }

                // Если значение isContainsZero не изменилость, значит строка не содержит 0
                if (!isContainsZero)
                    countLineNotContainsZero++;
            }

            Console.WriteLine($"Кол-во строк без 0: {countLineNotContainsZero}");
            for (int i = 5; i >= 0; i--)
            {
                if (countNubers[i] >= 2)
                {
                    Console.WriteLine($"Максимальное число, встречающихся в матрице более 1 раза: {i} (оно встретилось {countNubers[i]} раза)");
                    break; // Т.к. перебор массива начинается с наибольшего числа (5), то дальнейший перебор не имеет смысла
                }
            }
        }
    }
}
