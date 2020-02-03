using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVectorTask
{

    // В пространстве имен ReadOnlyVectorTask сделайте класс ReadOnlyVector с двумя публичными readonly-полями X и Y, которые устанавливаются в конструкторе.
    // ReadOnlyVector должен содержать метод Add(ReadOnlyVector other), который возвращает сумму векторов.
    // При работе с readonly классами часто хочется изготовить вектор "такой же, но с другим значением поля X или Y". Обеспечьте такую функциональность с помощью методов WithX(double) и WithY(double)

    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyVector vector = new ReadOnlyVector(3, 4);

            Console.WriteLine($"X = {vector.X}; Y = {vector.Y}");
            Console.WriteLine($"Vector = {vector.Add(vector).X}; {vector.Add(vector).Y}");
            Console.WriteLine(new string('-', 30));

            ReadOnlyVector vector1 = vector.WithX(5);
            Console.WriteLine($"X = {vector1.X}; Y = {vector1.Y}");
            Console.WriteLine($"New vector = {vector.Add(vector1).X}; {vector.Add(vector1).Y}");
            Console.WriteLine(new string('-', 30));
        }
    }

    public class ReadOnlyVector
    {
        public readonly double X;
        public readonly double Y;

        public ReadOnlyVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public ReadOnlyVector WithX(double x)
        {
            ReadOnlyVector other = new ReadOnlyVector(x, Y);
            return other;
        }

        public ReadOnlyVector WithY(double y)
        {
            ReadOnlyVector other = new ReadOnlyVector(X, y);
            return other;
        }

        public ReadOnlyVector Add(ReadOnlyVector other)
        {
            ReadOnlyVector newVector = new ReadOnlyVector(other.X + X, other.Y + Y);
            return newVector;
        }
    }
}
