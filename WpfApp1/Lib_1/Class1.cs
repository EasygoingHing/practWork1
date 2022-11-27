using System;

namespace Lib_1
{
    public static class MathString
    {
        /// <summary>
        /// Метод создаёт массив и заполняет его случайными значениями, генерируемыми в диапазоне от "min" до "max". 
        /// </summary>
        /// <param name="length">Длина массива.</param>
        /// <param name="min">Целое число.</param>
        /// <param name="max">Целое число.</param>
        /// <returns>Массив целых чисел.</returns>
        public static int[] CreateArr(int length, int min = 2, int max = 10)
        {
            int[] numbers = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(min, max);
            }

            return numbers;
        }

        /// <summary>
        /// Метод вычисляет сумму элеметов массива пока она не достигнет некоторого числа (limit), значение суммы и количество сгенерированных чисел.
        /// </summary>
        /// <param name="array">Массив целочисленных значений</param>
        /// <param name="limit">Целое число</param>
        /// <param name="sum">Сумма</param>
        /// <param name="kol">Целое число</param>
        /// <returns>Строка</returns>

        public static string SumLimit(int[] array, int limit, out int sum, out int kol)
        {
            sum = 0;
            kol = 0;
            string str = null;


            for (int i = 0; i < array.Length; i++)
            {
                if (sum <= limit)
                {
                    sum = sum + array[i];
                    kol++;
                    str = str + " " + array[i].ToString();
                }
            }
            return str;          
        }
    }
}
