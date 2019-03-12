using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            string tryAgain = "y";

            do
            {
                Console.WriteLine("Guess My Favorite Food. steak, pizza, or corn");
                string food = Console.ReadLine().ToLower();



                switch (food)
                {
                    case "steak":
                        Console.WriteLine("Correct");
                        Console.ReadLine();
                        break;
                    case "pizza":
                        Console.WriteLine("Incorrect");
                        Console.ReadLine();
                        break;
                    case "corn":
                        Console.WriteLine("Incorrect");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not an Option");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("Would You like to try again? y/n");
                tryAgain = Console.ReadLine();
            } while (tryAgain == "y");
            }
        }
   }

