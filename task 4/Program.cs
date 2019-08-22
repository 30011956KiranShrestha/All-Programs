using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result;

            result = num1 + num2;
              Console.WriteLine($"{num1} + {num2} = {result}");
            result = num1 - num2;
              Console.WriteLine($"{num1} - {num2} = {result}");
            result = num1 * num2;
              Console.WriteLine($"{num1} * {num2} = {result}");
            result = num1 / num2;
              Console.WriteLine($"{num1} / {num2} = {result}");

        }
    }
}
