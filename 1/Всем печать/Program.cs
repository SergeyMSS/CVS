using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Всем_печать
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(1, 2);
            Print("a", "b");
            Print(1, "a");
            Print(true, "a", 1);
        }

        public static void Print(params object[] argument)
        {
            for (var i = 0; i < argument.Length; i++)
            {
                Console.Write(argument[i]);
                if (i < argument.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
