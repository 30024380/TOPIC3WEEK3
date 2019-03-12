using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            string tryAgain = "y";
            do
            {
                Console.WriteLine("Enter A Number Here");
                int num = int.Parse(Console.ReadLine());

                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("EVEN");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("ODD");
                        Console.ReadLine();
                    }
                }
                else
                    Console.WriteLine("Invalid Input Try Again");
                    Console.ReadLine();
                    Console.WriteLine("Would You Like To Try Again?");
                    tryAgain = Console.ReadLine();
            } while (tryAgain == "y");
           
        }
    }
}
