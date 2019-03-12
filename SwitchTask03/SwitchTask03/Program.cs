//Name : Logan Tawhiri
//Purpose : Calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTask03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            string tryAgain = "y";
            do
            {
                Console.WriteLine("Please Enter a Number");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Another Number");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter an Operator (+ - / *)");
                string op1 = Console.ReadLine();

                double result = 0;

                switch (op1)
                {
                    case "+":
                        result = num1 + num2;
                        Console.ReadLine();
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.ReadLine();
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.ReadLine();
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("\n{0} {1} {2} = {3}", num1, op1, num2, result);

                Console.WriteLine("\nWould You Like to Try Again? y/n");
                tryAgain = Console.ReadLine().ToLower();
            } while (tryAgain == "y");
        }
    }
}
