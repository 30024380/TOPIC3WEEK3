using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter Your Pin");
            int pin = int.Parse(Console.ReadLine());

            if (pin >= 1000 && pin <= 9999)
            {                                     
                    Console.WriteLine("Please Enter Your Pin Again");
                    int pin2 = int.Parse(Console.ReadLine());
                if (pin == pin2)
                {
                    Console.WriteLine("Congratz");
                    Console.ReadLine();
                }
                if(pin != pin2)
                {
                    Console.WriteLine("WRONG");
                    Console.ReadLine();                       
                }


            }
            else
            {
                Console.WriteLine("This PIN number is not within the right parameters");
                Console.ReadLine();
            }


        }
    }
}
