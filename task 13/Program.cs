using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("please enter your second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("select an operator from (+, -, /, *)");
            string input = Console.ReadLine();
            double result = 0;
            switch(input)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                


            }
            Console.WriteLine($"{num1} {input} {num2} {result}");









        }
    }
}
