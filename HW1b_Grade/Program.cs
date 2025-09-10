// HW1b Grade

// Your Name: Chelsea Friedman
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            string firstname=Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string secondname=Console.ReadLine();

            Console.WriteLine("What is your student ID? ");
            int studentid=Convert.ToInt32(Console.ReadLine());

            // Percentages
            Console.WriteLine("What is your overall percentage grade for homework? ");
            double hwpercent=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation? ");
            double partpercent=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes? ");
            double quizpercent=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm? ");
            double midpercent=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final? ");
            double finalpercent=Convert.ToDouble(Console.ReadLine());

            double finalgrade = (hwpercent+partpercent+finalpercent+midpercent)/5;
            Console.WriteLine($"{firstname} {secondname} {(studentid)}, your final grade is {finalpercent:f2}%");


              
            Console.ReadKey();
        }
    }
}
