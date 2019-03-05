using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please Enter A Number");
            int t1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Another Number");
            int t2 = int.Parse(Console.ReadLine());

            if (t1 > t2)
            {
               Console.WriteLine(t1 + " " + "is Greater");
               Console.ReadLine();
            }
            if (t2 > t1)
            {
                Console.WriteLine(t2 + " " + "is Greater");
                Console.ReadLine();
            }
            if (t1 == t2)
            {
                Console.WriteLine(t1 + " and " + t2 + " " +  "are the same");
                Console.ReadLine();
            }     
            

        }
    }
}
