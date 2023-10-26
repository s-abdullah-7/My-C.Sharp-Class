using System;

namespace biggestTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number : ");
            string a = Console.ReadLine();

            Console.WriteLine("Enter Second Number : ");
            string b = Console.ReadLine();

            int.TryParse(a, out int firstNum);
            int.TryParse(b, out int secondNum);



            if (firstNum > secondNum)
            {
                Console.WriteLine("Biggest number is : " + firstNum);
            }
            else
            {
                Console.WriteLine("Biggest number is : " + secondNum);
            }

        }
    }
}