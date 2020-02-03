using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Склейка_массивов
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array.GetValue(i));
            }

            Console.WriteLine();
        }

        public static Array Combine(params Array[] arrays)
        {
            if (arrays.Length != 0)
            {
                var elementType = arrays[0].GetType().GetElementType();
                int summaryLength = LengthCalculate(arrays);
                var result = Array.CreateInstance(elementType, summaryLength);
                return CombineMethod(arrays, elementType, summaryLength);
            }
            else
                return null;
        }

        public static int LengthCalculate(Array[] arrays)
        {
            int summaryLength = 0;

            for (int i = 0; i < arrays.Length; i++)
                summaryLength += arrays[i].Length;

            return summaryLength;
        }

        public static Array CombineMethod(Array[] arrays, Type type, int summaryLength)
        {
            var result = Array.CreateInstance(type, summaryLength);
            int count = 0;

            for (int i = count; i < arrays.Length; i++)
            {
                var arrayObj = arrays[i];

                for (int j = 0; j < arrays[i].Length; j++)
                {
                    if (type == arrays[i].GetType().GetElementType())
                        result.SetValue(arrayObj.GetValue(j), count++);
                    else
                        return null;
                }
            }

            return result;
        }
    }
}
