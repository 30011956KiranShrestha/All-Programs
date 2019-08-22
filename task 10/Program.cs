using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the first letter: ");
            string a1 = Console.ReadLine();
            Console.Write("please enter the second letter: ");
            string a2 = Console.ReadLine();
            Console.Write("please enter the third number: ");
            string a3 = Console.ReadLine();

            
                if (a2 == "a" || a2 == "e" || a2 == "i" || a2 == "o" || a2 == "u")

                {
                if (a1 == a3)
                    Console.WriteLine($"{a1}{a2}{a3} is a palindrome..");
                else
                    Console.WriteLine("there is an issue");
            }

            else

                Console.WriteLine($"{a1}{a2}{a3} is not a palindrome..");
            Console.ReadLine();




        }
    }
}
