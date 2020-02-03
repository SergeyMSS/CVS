using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поиск_минимума
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
        }

        static Object Min(params Array[] arrays)
        {
            var objArr = arrays[0];
            Array.Sort(objArr);
            return objArr.GetValue(0);
        }
    }
}
