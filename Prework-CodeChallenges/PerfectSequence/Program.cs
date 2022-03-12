using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            challenge3();
        }
        static void challenge3()
        {
            Console.Write("Enter sequence of number: ");
            string userInput = Console.ReadLine();
            string[] strArr = userInput.Split();
            int product = 1;
            int sum = 0;
            foreach (string number in strArr)
            {
                if (int.Parse(number) < 0)
                {
                    Console.WriteLine("No because negative number");
                    break;
                }
                else
                {
                    product *= int.Parse(number);
                    sum += int.Parse(number);
                }                
            }
            if (product == sum)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No because sum does not the equal product");
            }
        }
    }
}
