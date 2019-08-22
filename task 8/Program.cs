using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter your number: ");
            double score = double.Parse(Console.ReadLine());
            string grade;
            if (score <=100 && score >= 90)
                grade = "A+";
            else if (score >= 80 && score <= 89)
                grade = "A";
            else if (score >= 70 && score <= 79)
                grade = "B+";
            else if (score >= 60 && score <= 69)
                grade = "B";
            else if (score >= 50 && score <= 59)
                grade = "C";
            else if (score >= 40 && score <= 49)
                grade = "D";
            else
                grade = "F";
            Console.WriteLine($"Your resulting score from {score} is {grade}");
            Console.ReadLine();
        }
    }
}
