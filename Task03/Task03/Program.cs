using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Please Enter Your Grade 1 - 100");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90 && grade <=100)
            {
                Console.WriteLine("Grade = A+");
                Console.ReadLine();
            }
            else if(grade >= 80 && grade <=89)
            {
                Console.WriteLine("Grade = A");
                Console.ReadLine();
            }
            else if(grade >= 70 && grade <=79)
            {
                Console.WriteLine("Grade = B+");
                Console.ReadLine();
            }
            else if(grade >= 60 && grade <=69)
            {
                Console.WriteLine("Grade = B");
                Console.ReadLine();
            }
            else if(grade >= 50 && grade <=59)
            {
                Console.WriteLine("Grade = C+");
                Console.ReadLine();
            }
            else if(grade >= 40 && grade <=49)
            {
                Console.WriteLine("Grade = D");
                Console.ReadLine();
            }
            else if(grade >= 0 && grade <=39)
            {
                Console.WriteLine("Grade = F");
                Console.ReadLine();
            }



        }    
    }
}
