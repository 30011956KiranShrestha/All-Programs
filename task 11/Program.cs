using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try and guess which of these is my favourite bird - kiwi/ piegon /crow / cuckoo");
            string bird = Console.ReadLine().ToLower();
            switch (bird)
            {
                case "kiwi":
                    Console.WriteLine("sorry..wrong answer.");
                    break;
                case "piegon":
                    Console.WriteLine("your guessed is correct");
                    break;
                case "crow":
                    Console.WriteLine("sorry..wrong answer");
                    break;
                case "cuckoo":
                    Console.WriteLine("sorry..wrong answer");
                    break;

                default:
                    Console.WriteLine("there is something wrong");
                    break;
            }
        }
    }
}
