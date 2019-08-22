using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a symbol: ");
            string str = Console.ReadLine();
            Console.Write($"how many times do u want this {str}");
                int num =int.Parse(Console.ReadLine());
            for(int i= 1; i <=num; i++ )
            {
                Console.WriteLine(str);
            }
           

        }
    }
}
