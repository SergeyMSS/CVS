using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Рекурсивный_бинарный_поиск
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = new long[] { 1, 1, 2, 3, 4, 5, 6, 6, 6, 8 };
            long value = 1;
            Console.WriteLine(FindLeftBorder(arr, value));
            Console.ReadLine();
        }

        private static int FindLeftBorder(long[] arr, long value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }

        public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        {
            if (left == right - 1)
            {
                return left;
            }

            var m = (left + right) / 2;

            if (array[m] < value)
            {
                return BinSearchLeftBorder(array, value, m, right);
            }

            return BinSearchLeftBorder(array, value, left, m);
        }
    }
}
