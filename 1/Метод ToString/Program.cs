using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle
            {
                A = new Point { X = 0, Y = 0 },
                B = new Point { X = 1, Y = 2 },
                C = new Point { X = 3, Y = 2 }
            };

            Console.WriteLine(triangle.ToString());
        }
    }

    public class Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return string.Format($"{X} {Y}");
        }
    }

    class Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public override string ToString()
        {
            return string.Format($"({A}) ({B}) ({C})");
        }
    }
}
