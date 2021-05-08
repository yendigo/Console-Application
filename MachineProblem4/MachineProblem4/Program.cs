using System;

namespace MachineProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program allows you to input two integer numbers and counts the number between them that is divisible by 5\r\n");

            int count = 0;

            Console.Write("Enter the first number:  ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int range = num1; range <= num2; range ++)
            {
                if (range % 5 == 0) count++;
            }

            Console.WriteLine("\r\nThere are {0} numbers that are divisible by 5 from {1} to {2}", count, num1, num2);
        }
    }
}
