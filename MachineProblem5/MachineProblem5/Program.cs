using System;

namespace MachineProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you input two whole numbers and show the greater number between them\r\n");

            Console.Write("Enter the first number:  ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            string GreatNum1 = (num1 >= num2) ? "higher" : "lower";
            string GreatNum2 = (num1 <= num2) ? "higher" : "lower";

            Console.WriteLine("\r\n{0} is {1}" + " while {2} is {3}", num1, GreatNum1, num2, GreatNum2);
        }
    }
}
