using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Снова_среднее_трёх
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOfThree(2, 5, 4));
            Console.WriteLine(MiddleOfThree(3, 1, 2));
            Console.WriteLine(MiddleOfThree(3, 5, 9));
            Console.WriteLine("B", "Z", "A");
            Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
        }

        static Object MiddleOfThree(object a, object b, object c)
        {
            var compareA = (IComparable)a;
            var compareB = (IComparable)b;
            if (compareA.CompareTo(b) < 0)
            {
                if (compareB.CompareTo(c) < 0)
                    return b;
                else if (compareA.CompareTo(c) > 0)
                    return a;
            }
            else
            {
                if (compareA.CompareTo(c) < 0)
                    return a;
                else if (compareB.CompareTo(c) > 0)
                    return b;
            }
            return c;
        }
    }
}
