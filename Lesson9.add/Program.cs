using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9.add
{
    class Program
    {
        static void Wrte(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int [10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 9);
            }

            Wrte(array);

            Console.ReadKey();

        }
    }
}
