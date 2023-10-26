using System;

namespace myProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string num1 = Console.ReadLine();
            int.TryParse(num1, out int firstnumber);
           
            Console.WriteLine("Enter second number: ");
            string num2 = Console.ReadLine();
            int.TryParse(num2, out int secondnumber);

            int sum = 0;
            Console.WriteLine("Enter the operator: ");
            string operators = Console.ReadLine();


            switch (operators)
            {
                case "+":
                    sum = firstnumber + secondnumber;
                    Console.WriteLine(sum);
                    break;
                case "-":
                    sum = firstnumber - secondnumber;
                    Console.WriteLine(sum);
                    break;
                case "*":
                    sum = firstnumber * secondnumber;
                    Console.WriteLine(sum);
                    break;
                case "/":
                    sum = firstnumber / secondnumber;
                    Console.WriteLine(sum);
                    break;
            }




        }
    }

}

