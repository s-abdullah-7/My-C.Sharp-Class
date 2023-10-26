using System;

namespace area
{
    class Program
    {
        static double CalculateAreaRectangle(double length,double width)
        {
            return length * width;
        }
        static double CalculateAreaCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
        static double CalculateAreaSquare(double length)
        {
            return length * length;
        }
        static double CalculateAreaTriangle(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAreaCircle(10));
            Console.WriteLine(CalculateAreaRectangle(10,20));
            Console.WriteLine(CalculateAreaSquare(10));
            Console.WriteLine(CalculateAreaTriangle(10,100));


        }
    }
}