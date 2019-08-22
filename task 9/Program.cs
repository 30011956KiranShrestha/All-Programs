using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your 4 digit pin number: ");
            int pin1 = int.Parse(Console.ReadLine());
            if (pin1 >= 1000 && pin1 <= 9999)
            {
                Console.Write("please re-enter your pin number: ");
                int pin2 = int.Parse(Console.ReadLine());
                if (pin1 == pin2)
                    Console.WriteLine("pin accepted");
                else
                    Console.WriteLine("pin did not match");

            }
             else
            {
                Console.WriteLine("sorry..out of range");


            }
        }
    }
}
