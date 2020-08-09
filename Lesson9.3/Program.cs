using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._3
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            int[] array2 = new int[array.Length];
            int j = array2.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                array2[j] = array[i];
                j--;
            }

            return array2;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] array2 = new int[count];
            int j = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = 1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i >= index - 1 && i < array2.Length)
                {
                    array2[j] = array[i];
                    j++;
                }
            }

            return array2;
        }

        static void Wrte(int[] array)
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
            int[] array2 = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 9);
            }

            Console.Write("Введите с какого елемента начать новый масив : ");
            int newN = int.Parse(Console.ReadLine());
            Console.Write("Введите длину нового масива : ");
            int length = int.Parse(Console.ReadLine());
            int[] newArray = new int[length];

            array2 = MyReverse(array);
            newArray = SubArray(array, newN, length);

            Wrte(array);
            Wrte(array2);
            Wrte(newArray);

            Console.ReadKey();
        }
    }
}
