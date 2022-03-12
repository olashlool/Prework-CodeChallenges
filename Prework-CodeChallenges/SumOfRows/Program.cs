using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfRows
{
    class Program
    {
        static void Main(string[] args)
        {
            challenge4();
        }
        static void challenge4()
        {

            Console.Write("Enter the number of Row: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of Columns: ");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[m, n];
            //Console.WriteLine(two.GetLength(0)); 
            //Console.WriteLine(two.GetLength(1));
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 15);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    sum = sum + arr[i, j];
                }
                Console.WriteLine("Sum of the row " + i + " = " + sum);
                sum = 0;
            }
        }
    }
}