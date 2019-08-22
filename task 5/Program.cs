using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)

                Console.WriteLine($"{num1} is the big number");
            else if (num1 < num2)
                Console.WriteLine($"{num2} is the largest number");
            else
                Console.WriteLine($"{num1} is equal to {num2}");

            
        }
    }
}
