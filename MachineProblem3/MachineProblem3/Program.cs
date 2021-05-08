using System;

namespace MachineProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you input information about a company and the manager \r\n");

            Console.Write("Enter the company name: ");
            string ComName = Console.ReadLine();

            Console.Write("Enter the company address: ");
            string ComAdd = Console.ReadLine();

            Console.Write("Enter the company phone number: ");
            string ComNum = Console.ReadLine();

            Console.Write("Enter the company fax number: ");
            string ComFax = Console.ReadLine();

            Console.Write("Enter the company web site: ");
            string ComWeb = Console.ReadLine();

            Console.WriteLine("\r\nEnter the company manager's information \r\n");

            Console.Write("First name: ");
            string Man1st = Console.ReadLine();

            Console.Write("Last name: ");
            string ManLast = Console.ReadLine();

            Console.Write("Age: ");
            string ManAge = Console.ReadLine();

            Console.Write("Phone number: ");
            string ManNum = Console.ReadLine();

            Console.WriteLine("\r\nThis is the information of the company and the manager you entered \r\n");

            Console.WriteLine("Company name - {0} \r\n" + "Address: - {1} \r\n" + "Phone number - {2} \r\n" + "Fax - {3} \r\n" + "Website - {4} \r\n", ComName, ComAdd, ComNum, ComFax, ComWeb);

            Console.WriteLine("Manager name - {0} {1} \r\n" + "Age - {2} \r\n" + "Phone number - {3}", Man1st, ManLast, ManAge, ManNum);
        }
    }
}
