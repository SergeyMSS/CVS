using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дробь
{
    class Program
    {
        static void Main(string[] args)
        {
            Check(2, 4);
        }

        public static void Check(int num, int den)
        {
            var ratio = new Ratio(num, den);
            Console.WriteLine("{0}/{1} = {2}",
                ratio.Numerator, ratio.Denominator,
                ratio.Value.ToString(CultureInfo.InvariantCulture));
        }
    }

    public class Ratio
    {
        public readonly int Numerator;
        public readonly int Denominator;

        public double Value
        {
            get { return (double)Numerator / Denominator; }
        }

        public Ratio(int num, int den)
        {
            Numerator = num;
            if (den <= 0)
                throw new ArgumentException();
            else
                Denominator = den;
        }
    }
}
