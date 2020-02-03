using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Последствия_boxing
{
    class Program
    {
        public struct S { int A; }
        static void Main(string[] args)
        {
            object[] s = new object[2];
            s[0] = new S();
            s[1] = s[0];
            Console.WriteLine(s[0] == s[1]);
            //S s = new S();
            //ShowEquals(s, s);
        }

        //static void ShowEquals(object o1, object o2)
        //{
        //    Console.WriteLine(o1 == o2);
        //}
    }
}
