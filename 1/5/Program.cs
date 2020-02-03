using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static double MyNextDouble(Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }

        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine(MyNextDouble(rnd, 10, 20));
            Console.WriteLine(rnd.NextDouble(10, 20));
            var array = new int[] { 1, 2, 3, 4, 5 };
            array.Swap(0, 1);
        }
    }

    public static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
    }

    public static class ArrayExtensions
    {
        public static void Swap(this int[] array, int i, int j)
        {
            var t = array[i];
            array[i] = array[j];
            array[j] = t;
        }
    }
}
