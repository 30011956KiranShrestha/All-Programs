using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int total =1;
            int i = 1;
            while (i <=10)
            {
                total *= i;
                i++;

            }
            Console.WriteLine($"10 factorial is: {total}");
            Console.ReadLine();
        }
    }
}
