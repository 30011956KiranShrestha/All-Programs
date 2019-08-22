using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task__21
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
           /* for(int i =1; i <=10; i++)
            {
                Console.Write("please enter your number: ");
                total = total + int.Parse( Console.ReadLine());
            }
            Console.WriteLine($"Total: {total}");
            */
            do
            {
                Console.Write("please enter a number: ");
                total = total + int.Parse(Console.ReadLine());
                Console.Write("would you like to add another number (Y/N)");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            }
            while (true);
            Console.WriteLine($"Total: {total}" );
        }
    }
}
