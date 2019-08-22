using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int myNum = rand.Next(1, 10);
            Console.WriteLine($"{myNum} \nplease guess a number from (1-10)");
            int userNum = int.Parse(Console.ReadLine());
            if (userNum == myNum)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("yayy you win..");

            }
            else if (userNum > myNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("bad luck..your guess is too high");
            }
            else if (userNum < myNum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("bad luck.. your guess is too low");
            }
            

              
            

        }
    }
}
