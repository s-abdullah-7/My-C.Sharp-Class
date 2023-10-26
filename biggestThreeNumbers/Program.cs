using System;

namespace biggestTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();
            Console.WriteLine("Enter third number");
            string c = Console.ReadLine();

            int.TryParse(a, out int firstNum);
            int.TryParse(b, out int secondNum);
            int.TryParse(c, out int thirdNum);

            if(firstNum > secondNum & firstNum > thirdNum)
            {
                Console.WriteLine(firstNum);
            }
            else if(secondNum> firstNum & secondNum > thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
            
        }
    }
}