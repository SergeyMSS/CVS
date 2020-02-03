using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace По_часовой_стрелке
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[]
            {
                new Point { X =    1, Y =  0 },
                new Point { X =   -1, Y =  0 },
                new Point { X =    0, Y =  1 },
                new Point { X =    0, Y = -1 },
                new Point { X = 0.01, Y =  1 }
            };

            Array.Sort(array, new ClockwiseComparer());

            foreach (Point e in array)
                Console.WriteLine($"{e.X} {e.Y}");
        }
    }

    public class Point
    {
        public double X;
        public double Y;
    }

    public class ClockwiseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var point1 = (Point)x;
            var point2 = (Point)y;

            double vector1 = Math.Atan2(point1.X, point1.Y);
            double vector2 = Math.Atan2(point2.X, point2.Y);


            return vector2.CompareTo(vector1);
        }
    }
}
