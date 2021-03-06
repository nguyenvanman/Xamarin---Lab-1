﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            var n = Convert.ToInt32(Console.ReadLine());

            var sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / ((i + 2) * CalculateFactorial(i));
            }
            Console.WriteLine("Result: " + sum);
            Console.ReadKey();
        }
        static long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalculateFactorial(n - 1);
        }
    }
}
