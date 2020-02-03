using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ленивые_коллекции
{
    public class Sequences
    {
        public static IEnumerable<int> Fibonacci
        {
            get
            {
                var a = 1;
                var b = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var c = a + b;
                    a = b;
                    b = c;
                    yield return c;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var e in )
        }
    }
}
