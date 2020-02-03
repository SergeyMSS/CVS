using System;
using System.Globalization;

namespace _2
{
    class Program
    {
        static void Main()
        {
            var city = new City();
            city.Name = "Ekaterinburg";
            city.Location = new GeoLocation();
            city.Location.Latitude = 56.50;
            city.Location.Longitude = 60.35;

            Console.WriteLine(($"I love {city.Name} located at ({city.Location.Longitude.ToString(CultureInfo.InvariantCulture)}, {city.Location.Latitude.ToString(CultureInfo.InvariantCulture)})"));
        }

    }
    public class City
    {
        public string Name;
        public GeoLocation Location = new GeoLocation();
    }

    public class GeoLocation
    {
        public double Latitude;
        public double Longitude;
    }

}
