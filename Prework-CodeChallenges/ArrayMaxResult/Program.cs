using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            challenge1();
        }

        static void challenge1()
        {
            Console.Write("Enter 5 Number btween 1-10 separate by space :");
            string userInput = Console.ReadLine();
            string[] strArr = userInput.Split();

            Console.Write("Please Select Number between [" + string.Join(", ", strArr) + "] ");
            string slectNumber = Console.ReadLine();
            int count = 0;
            foreach (string i in strArr)
            {
                if (i == slectNumber)
                {
                    count++;
                }
            }
            Console.WriteLine($"The number {slectNumber} has a score of {int.Parse(slectNumber) * count}");
        }


    }
}
