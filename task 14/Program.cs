using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int finish = 7;
            for (int i=3; i <= finish; i++)
            {
                Console.WriteLine($"{i} \t{i * 10} \t{i * 100} \t{i * 1000}");
            }
            Console.WriteLine(">>>>while loop<<<");

            int counter = 3;
            while(counter<=finish)
            {
                Console.WriteLine($"{counter} \t{counter * 10} \t{counter * 100} \t{counter * 1000}");
                counter++;
            }
            Console.WriteLine(">>>>do while loop<<<");
            counter = 3;
            do
            {
                Console.WriteLine($"{counter} \t{counter * 10} \t{counter * 100} \t{counter * 1000}");
                counter++;

            }
            while (counter <= finish);
        }
    }
}
