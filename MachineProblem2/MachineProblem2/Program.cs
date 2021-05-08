using System;

namespace MachineProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you input the radius of a circle and show its area and perimeter \r\n");

            Console.Write("Enter the radius of a circle: ");
            double rad1 = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(rad1, 2);  
            Console.WriteLine("The area of the circle with the radius you input " + "is {0:0.000}", area);

            double peri = 2 * Math.PI * rad1;
            Console.WriteLine("While the perimeter " + "is {0:0.000}", peri);
        }
    }
}
