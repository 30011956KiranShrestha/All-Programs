using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
                int number = rand.Next(1, 5);
                Console.WriteLine($"{number}");



            int guess = 0;
            do

            {
                Console.Write("try and guess the number: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == number)
                    break;
                
                

            } while (true);
            Console.WriteLine("you are right");

        }
    }
}
