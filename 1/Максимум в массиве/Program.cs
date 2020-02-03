using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Максимум_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 3, 1, 2 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));
        }

        static T Max<T>(T[] source)
            where T : IComparable
        {
            if (source.Length == 0)
                return default(T);
            return source.Max();
        }
    }
}
