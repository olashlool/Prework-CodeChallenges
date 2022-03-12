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
            string[,] two = new string[m, n];
            //Console.WriteLine(two.GetLength(0)); 
            //Console.WriteLine(two.GetLength(1));
          
            int[,] arr = new int[3, 5] { 
                                { 1, 2, 3, 4, 5 }, 
                                { 6, 7, 8, 9, 10 }, 
                                { 11, 12, 13, 14, 15 } 
                                };


            int sum = 0;
            for ( int i = 0; i < m; ++i)
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
