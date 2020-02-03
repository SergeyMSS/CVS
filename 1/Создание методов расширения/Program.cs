using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Создание_методов_расширения
{
    class Program
    {
        static void Main(string[] args)
        {
            var arg1 = "100500";
            Console.WriteLine(arg1.ToInt() + "42".ToInt());
        }
    }

    public static class StringExtensions
    {
        public static int ToInt(this String str)
        {
            return int.Parse(str);
        }
    }
}
