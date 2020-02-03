using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфейс_IComparer
{
    public class Point
    {
        public double X;
        public double Y;
    }

    class DistanceToZeroComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var point1 = (Point)x;
            var point2 = (Point)y;

            return
                Math.Sqrt(point1.X * point1.X + point1.Y * point1.Y).CompareTo(Math.Sqrt(point2.X * point2.X + point2.Y * point2.Y));
        }
    }

    class XDecreasingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var point1 = x as Point;
            var point2 = (Point)y;
            return -point1.X.CompareTo(point2.X);
        }
    }

    class Program
    {
        public static void Sort(Array array, IComparer comparer)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    object element1 = array.GetValue(j - 1);
                    object element2 = array.GetValue(j);
                    if (comparer.Compare(element1, element2) < 0)
                    {
                        object temporary = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var array = new[]
            {
                new Point{ X = 1, Y = 1 },
                new Point{ X = 2, Y = 2 }
            };

            Sort(array, new DistanceToZeroComparer());
            Sort(array, new XDecreasingComparer());
        }
    }
}
