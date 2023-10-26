using System;

namespace Calculator
{
    class Program
    {
        static int add(int a, int b){ return a + b; }
        static double add(double a, double b){ return a + b; }
        static int subtract(int a,int b) { return a - b; }
        static double substract(double a, double b) { return a - b; }

        static int multiply(int a,int b) { return a * b; }
        static double multiply(double a, double b) { return a * b; }

        static int divide(int a, int b) { return (a / b); }
        static double divide(double a, double b) { return a / b; }

        static void Main(string[] args)
        {

            Console.WriteLine(multiply(3.5, 3.3));

        }
    }
}