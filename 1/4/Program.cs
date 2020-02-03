using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //SomeClass.s = 42;
            //new SomeClass().d = 55;

            var obj1 = new SomeClass();
            var obj2 = new SomeClass();
            obj1.Run();
            obj2.Run();
            obj1.Run();
        }
    }

    class SomeClass
    {
        public static int s = 1;
        public int d = 1;

        public void Run()
        {
            Console.Write(s + " " + d + " ");
            s++;
            d++;
        }
    }
}
