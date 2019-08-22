using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine($"Hello {name} {lname}, nice to meet you..");
            Console.ReadLine();

        }
    }
}
