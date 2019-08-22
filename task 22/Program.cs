using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for(int i =0; i <num; i++)
            {
                if(i%2!=0)
                    Console.WriteLine(i);
            }
        }
    }
}
