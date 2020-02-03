using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int x = 0;
            //int i = 0;

            //for (; i < arr.Length; i++)
            //{
            //    x += arr[i];
            //}

            do
            {
                Console.WriteLine("do");
            }
            while (false);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
