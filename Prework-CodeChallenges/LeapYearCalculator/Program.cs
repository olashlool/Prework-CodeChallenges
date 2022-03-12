using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            challenge2();
        }
        static void challenge2()
        {
            Console.Write("Enter a year: ");
            string userInput = Console.ReadLine();
            int year = int.Parse(userInput);

            if (year % 4 != 0)
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            else if ((year % 100 == 0) && (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is a leap year");
            }
        }
    }
}
