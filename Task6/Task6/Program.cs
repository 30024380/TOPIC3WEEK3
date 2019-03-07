using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
           
            string letter1;
            string letter2;
            string letter3;

            string tryAgain = "y";

            do
            {
                Console.Clear();
                Console.WriteLine("Please Enter A Letter");
                letter1 = Console.ReadLine();

                Console.WriteLine("Please Enter A Vowel");
                letter2 = Console.ReadLine();

                Console.WriteLine("Please Enter Another Letter");
                letter3 = Console.ReadLine();



                if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
                {
                    if (letter1 == letter3)
                    {
                        Console.WriteLine("This Word Is A Palindrome" + " " + letter1 + " " + letter2 + " " + letter3);
                        Console.ReadLine();
                    }
                    else if (letter1 != letter3)
                    {
                        Console.WriteLine("This Is Not A Word");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                    Console.ReadLine();
                }

                Console.Write("Do you want to try again(y/n)? ");
                tryAgain = Console.ReadLine();
            } while (tryAgain == "y");
            }                        
        }
    }

