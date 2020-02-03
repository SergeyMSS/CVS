using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Брошенный_код
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOnSize(1);
            TestOnSize(2);
            TestOnSize(0);
            TestOnSize(3);
            TestOnSize(4);
        }

        static void TestOnSize(int size)
        {
            var result = new List<int[]>();
            MakePermutation(new int[size], 0, result);
            foreach (var permutation in result)
            {
                WritePermutation(permutation);
            }
        }

        static void MakePermutation(int[] permutation, int position, List<int[]> result)
        {
            if (position == permutation.Length)
            {
                // доделать
                for (int i = 0; i < permutation.Length; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < permutation.Length; i++)
                {
                    var index = Array.IndexOf(permutation, i, 0, position);
                    // если i не встречается среди первых position элементов массива, то index == -1
                    //иначе index - это номер позиции элемента в массиве.
                    if (index == -1)
                    {
                        // если число i ещё не было использовано, то...
                        // доделать

                    }
                }
            }
        }
    }
}
