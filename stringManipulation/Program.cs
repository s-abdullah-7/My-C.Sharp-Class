using System;
using System.Security.Cryptography.X509Certificates;

namespace stringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5 , 8 , 9 , 6 };
            
            //int j = ' ';

            //foreach(int number in numbers)
            //{
            //    if(number < j)
            //    {
            //        j = number;
            //    }

            //}
            //Console.WriteLine(j);

            int j = 0;

            foreach( int i in numbers )
            {
                j = i + j;
            }

            Console.WriteLine(j);




        }
    }
}
