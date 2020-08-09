using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._4
{
    class Program
    {
        static void AddOne(int[] array, int n)
        {
            int[] array2 = new int[n + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[n] = 0;
            Write(array2);
        }

        static void AddZero(int[] array, int n)
        {
            int j = 1;
            int[] array2 = new int[n + 1];
            array2[0] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array2[j] = array[i];
                j++;
            }
            Write(array2);
        }
        static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество елементов : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 9);
            }
            Write(array);
            AddOne(array, n);
            AddZero(array, n);

            Console.ReadKey();
        }
    }
}
