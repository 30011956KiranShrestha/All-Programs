using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_25
{
    class Program
    {
        static void Main(string[] args)
        {
            float total = 0;
            for (int i =1; i <=20; i++)
            {
                Console.Write($"please enter number {i}: ");
                total = total + float.Parse(Console.ReadLine());


            }
            Console.WriteLine($"The total number you entered is: {total}");
            Console.ReadLine();
        }
    }
}
