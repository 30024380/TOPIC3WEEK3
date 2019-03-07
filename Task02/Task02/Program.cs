using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int my = 10;
            Console.ForegroundColor = ConsoleColor.White;

            Random rand = new Random();
            int my2 = rand.Next(1, 11);

            Console.WriteLine("Guess My Number Between 1 - 10");
            int user = int.Parse(Console.ReadLine());

            if (user == my2)
            {
                Console.WriteLine("Congratz you have guessed the number");
                Console.ReadLine();
            }
            if (user > my2)
            {
                Console.WriteLine("Your guess is too high");
                Console.ReadLine();
            }
            if (user < my2)
            {
                Console.WriteLine("Your guess is too low");
                Console.ReadLine();
            }




        }
    }
}

    

