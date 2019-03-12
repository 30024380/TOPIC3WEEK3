using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            string tryAgain = "y";

            do
            {

                Console.WriteLine("Please Enter Your Fruit. Apples, Bananas, Kiwifruit, or Orange");
                string fruit = Console.ReadLine().ToLower();

                switch (fruit)
                {
                    case "apples":
                        Console.WriteLine("Price per Kg = $1.25");
                        Console.ReadLine();
                        break;
                    case "bananas":
                        Console.WriteLine("Price per Kg = $3.15");
                        Console.ReadLine();
                        break;
                    case "kiwifruit":
                        Console.WriteLine("Price per Kg = $4.65");
                        Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("Price per Kg = $2.75");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Not An Option");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("Would You Like To Look Again? y/n");
                tryAgain = Console.ReadLine().ToLower();
            } while (tryAgain == "y");
            }
        }
    }

