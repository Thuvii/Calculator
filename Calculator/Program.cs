using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("Hello, welcome to the calculator program!");
                Console.WriteLine("Please enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());


                Console.WriteLine("Please enter operation");
                string n = Console.ReadLine();
                int result = 0 ;
                switch (n)
                {
                    case "+":
                        result = (number1 + number2);
                        break;
                    case "-":
                        result = (number1 - number2);
                        break;
                    case "/":
                        result = (number1 / number2);
                        break;
                    case "*":
                        result = (number1 * number2);
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }


                Console.WriteLine("Result: " + result);
                Console.WriteLine("Would you like to continue? (Y =yes, N = no)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.ReadKey();  
        }
    }
}
