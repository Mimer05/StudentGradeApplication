using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;//for unicode char to be show in output

            Console.WriteLine("============ ۞ Student Grade Application ۞ ================");
           Console.Write("Name: ");// input name
           string name = Convert.ToString(Console.ReadLine());
           //Input of grades
            Console.WriteLine("۞--------------------------------۞");
            Console.WriteLine("Enter your grades");

            Console.Write("English: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Math: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Science: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Filipino: ");
            double grade4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("History: ");
            double grade5 = Convert.ToDouble( Console.ReadLine());
            // the calculation of average
            double sum = grade1 + grade2 + grade3 + grade4 + grade5;
            double average = sum / 5;
            Console.WriteLine("۞--------------------------------۞");
            //the conditional statements
            if (average >= 75.00)
            {
                Console.WriteLine("The student passed");
                Console.WriteLine("The general average of " + name + " is " + average);
            }
            else
            {
                Console.WriteLine("The student failed ");
                Console.WriteLine("The general average of " + name + " is " + average);
            }
            Console.ReadKey();
        }
    }
}
