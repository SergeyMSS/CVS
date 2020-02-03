using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1 }, new[] { 0 })));
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1, 2 }, new[] { 1, 2 })));
            Console.WriteLine(string.Join(" ", ZipSum(new int[0], new int[0])));
            Console.WriteLine(string.Join(" ", ZipSum(new[] { 1, 3, 5 }, new[] { 5, 3, -1 })));
            CheckYieldReturn();

        }

        private static IEnumerable<int> ZipSum(IEnumerable<int> first, IEnumerable<int> second)
        {
            var e1 = first.GetEnumerator();
            var e2 = second.GetEnumerator();
            while (first.Count >= count)
            {
                var result = e1 + e2;
                yield return result;
            }
        }
    }
}
