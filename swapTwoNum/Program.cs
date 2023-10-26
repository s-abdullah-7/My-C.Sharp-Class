using System;

namespace biggestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            

            int.TryParse(a, out int firstNum);
            int.TryParse(b, out int secondNum);
            
            int c = firstNum;
            firstNum = secondNum;
            secondNum = c;
          

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);

        }
    }
}
