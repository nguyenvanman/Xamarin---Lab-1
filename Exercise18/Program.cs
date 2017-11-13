using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            PrintPascalTriangle(n);
            Console.ReadKey();
        }

        static void PrintPascalTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(CalculateCombination(i, k) + "  ");
                }
                Console.WriteLine();
            }
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }
        static long CalculateCombination(int n, int k)
        {
            if (k > n) return 0;   
            return CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k));
        }
    }
}
