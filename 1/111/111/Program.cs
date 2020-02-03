using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> d;
            d = () => 0;
            d += () => 1;
            d += () => 2;
            int b = d();
        }
    }
}
