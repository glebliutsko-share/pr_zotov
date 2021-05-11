using System;

namespace Dvym2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем размер матрицы
            Console.Write("Размер матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Инициализируем 2мерный массив
            int[,] matrix = new int[n, n];
            // Заполняем его значениями, введенные с консоли
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); // Просто вывод пустой строки, что бы отделить вывод матрицы
            // Вывод на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            int s = 0;  // Перменная, хранящая сумму
            // По задачи нам надо найти сумму нижнией части матрицы, разделенной главной диогональю.
            // На каждой следующий строки матрицы нам нужно сложить на 1 элемент больше. Т.е. на 1-ой строке мы складываем 1 элемент, на 2-ой строке 2 элемента и т.д.
            for (int i = 0; i < n; i++)
            {
                // i + 1, т.к. ноумерация начинается с 0. Либо можно было написать j <= i
                for (int j = 0; j < i + 1; j++)
                    s += matrix[i, j];
            }
            Console.WriteLine($"Сумма выделеных элементов: {s}");
        }
    }
}
