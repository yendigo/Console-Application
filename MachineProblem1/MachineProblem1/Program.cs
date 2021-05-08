using System;

namespace MachineProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you input three integers and show its sum \r\n");

            Console.Write("Enter the three number you want to add: \r\n");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            Console.WriteLine("The sum of the three numbers you input " + "is {0}", sum);
        }
    }
}
