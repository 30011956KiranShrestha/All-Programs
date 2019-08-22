using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a symbol to use: ");
            string symbol = Console.ReadLine();
            Console.Write("please enter the height of the rectengle" );
            int h = int.Parse(Console.ReadLine());
            Console.Write("please enter the width of the rectengle");
            int w = int.Parse(Console.ReadLine());
            for (int i =0; i <h; i++)
            {
                for (int j = 0; j < w; j++)
                {

                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            
        }
    }
}
