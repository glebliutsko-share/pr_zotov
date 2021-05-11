using System;

namespace Dvym3
{
    class Program
    {
        const int MATRIX_LINE = 5;
        const int MATRIX_COLLUMN = 3;

        static void Main(string[] args)
        {
            // *** Код из 1 ПР (поменял только промежутки) ***
            int[,] matrix = new int[MATRIX_LINE, MATRIX_COLLUMN];

            // Заполнение матрицы
            Random rnd = new Random();
            for (int i = 0; i < MATRIX_LINE; i++)
            {
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                }
            }

            // Вывод матрицы
            for (int i = 0; i < MATRIX_LINE; i++)
            {
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            // *** Конец кода из 1 ПР ***

            // Массив в которых будут хранится минимальные элементы строк и максимальные элементы колонок
            int[] line_min = new int[MATRIX_LINE];
            // Заполняем массив максимально возможным значением. Так как у нас промежуток [-10; 10], то максимальное значение 10.
            for (int i = 0; i < MATRIX_LINE; i++) line_min[i] = 10;

            // Массив в которых будут хранится максимальные элементы колонок
            int[] collumn_max = new int[MATRIX_COLLUMN];
            // Заполняем массив минимально возможным значением. Так как у нас промежуток [-10; 10], то минимальное значение -10.
            for (int i = 0; i < MATRIX_COLLUMN; i++) collumn_max[i] = -10;

            /*
             * Зачем мы заполняли массивы максимальным и минимальным значениями?
             * 
             * Если мы не обнулим переменную, хранящую минимальное значение,
             * то она будет равно 0 (такое значение у чисел по умолчанию в C#), то программа будет игнорировать все значения больше 0.
             * И если у нам не будет значение <0, то вместо правильного числа, будет выведен 0.
             * 
             * Тоже самое и для поиска максимального значения только наоборот.
             * 
             * КАРОЧЕ:
             * Если мы ищем максимальное значение, то стартовое значение должно быть минимальным, а если ищем минимальное значение, то максимальным.
             */

            for (int i = 0; i < MATRIX_LINE; i++)
            {
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                {
                    // Типичный алгоритм поиска максимального и минимального значения. Надеюсь тут понятно :)
                    if (line_min[i] > matrix[i, j]) line_min[i] = matrix[i, j];

                    if (collumn_max[j] < matrix[i, j]) collumn_max[j] = matrix[i, j];
                }
            }

            for (int i = 0; i < MATRIX_LINE; i++)
                for (int j = 0; j < MATRIX_COLLUMN; j++)
                    if (collumn_max[j] == line_min[i])
                        Console.WriteLine($"Найдена седловая точка. Строка - {i + 1}, столбец - {j + 1}, значение - {matrix[i, j]}");
        }
    }
}
