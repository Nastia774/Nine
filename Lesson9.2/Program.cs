using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._2
{
    class Program
    {
        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество елементов : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 9);
            }

            int max = Max(array);

            int min = Min(array);

            Console.Write("Нечетные значения масива : ");
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            double sr = sum / n;
            Console.WriteLine();
            Console.WriteLine($"Максимальное значение : {max}");
            Console.WriteLine($"Минимальное значение : {min}");
            Console.WriteLine($"Сумма всех елементов : {sum}");
            Console.WriteLine($"Среднее арифметическое всех елементов : {sr}");

            Console.ReadKey();
        }
    }
}
