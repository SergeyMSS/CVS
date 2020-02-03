using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Сортировка_диапазона
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 3, 2, 1 };
            int left = 0;
            int right = 3;

            PrintMethod(array);

            BubbleSortRange(array, left, right);

            Console.ReadLine();
        }

        public static void BubbleSortRange(int[] array, int left, int right)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = left; j < right; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
                }
            }

            PrintMethod(array);
        }

        public static void PrintMethod(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 15));
        }
    }
}
