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
            Console.WriteLine("Enter A Number Here");
            int num = int.Parse(Console.ReadLine());
            
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
    }
}
