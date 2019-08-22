using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 7;
            int finish = 13;
            for (int i=1; i <=finish; i++)
            {
                Console.WriteLine($"\t{i} X {start} = {i * start}");
            }
            Console.WriteLine(">>>while loop<<<");
            int counter = 1;
            while(counter <=finish)
            {
                Console.WriteLine($"\t{counter} X {start} = {counter * start}");
                counter++;
            }
            Console.WriteLine(">>>do while loop<<<");
            counter = 1;
            do
            {
                Console.WriteLine($"\t{counter} X {start} = {counter * start}");
                counter++;
            }
            while (counter <= finish);
        }
    }
}
