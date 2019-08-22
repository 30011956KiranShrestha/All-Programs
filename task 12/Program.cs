using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPrice check on fruit - Apples / Bananas / Kiwifruit / Oranges");
            string fruit = Console.ReadLine().ToLower();





            string response;
            switch (fruit)
            {

                case "apples":
                    response = "\nApples:\t $1.25 per kg";
                    break;
                case "bananas":
                    response = "\nBananas:\t $3.15 per kg";
                    break;
                case "kiwifruit":
                    response = "\nKiwifruit:\t $4.65 per kg";
                    break;
                case "oranges":
                    response = "\nOranges:\t $2.75 per kg";
                    break;
                default:
                    response = "\nOops, something went wrong...";
                    break;
            }

            Console.WriteLine($"{response}");

            Console.ReadLine();
        }
    }
}
