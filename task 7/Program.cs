using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine($"{input} is a even number");
            else
                Console.WriteLine($"{input} is a odd number");
        }
    }
}
