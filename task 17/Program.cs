using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("display all odd numbers from 76 to 46");
           Console.ReadLine();


            int start =76;
            int finish = 46;
            while (start >=finish)
            {
                if (start % 2 != 0)
                    Console.WriteLine(start);
                start--;
            }
        }
    }
}
