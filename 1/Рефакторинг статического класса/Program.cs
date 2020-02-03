using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рефакторинг_статического_класса
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = new SuperBeautyImageFilter();
            filter.ImageName = "Paris.jpg";
            filter.GaussianParameter = 0.4;
            filter.Run();
        }
    }

    public class SuperBeautyImageFilter
    {
        public string ImageName;
        public double GaussianParameter;
        public void Run()
        {
            Console.WriteLine("Processing {0} with parameter {1}", ImageName, GaussianParameter.ToString(CultureInfo.InvariantCulture));
        }
    }
}
