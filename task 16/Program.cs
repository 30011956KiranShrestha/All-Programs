using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)

        {
            int finish = 10;
            for (int i = 0; i <= finish; i++)
            {
                Console.WriteLine($"{i} \t{i * i} \t{i * i * i}");
            }
            Console.WriteLine(">>while loop<<");
            int counter = 1;
            while (counter <=finish)
            {
                Console.WriteLine($"{counter} \t{counter * counter} \t{counter * counter * counter}");
                counter++;
            }
            Console.WriteLine(">>>>do while loop<<<");
            counter = 1;
            do
            {
                Console.WriteLine($"{counter} \t{counter * counter} \t{counter * counter * counter}");
                counter++;
            }
            while (counter <= finish);

        }
    }
}
