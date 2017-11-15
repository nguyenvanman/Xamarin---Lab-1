﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
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
                sum += 1.0 / (i * (i + 1));
            }
            Console.WriteLine("Result: " + sum);
            Console.ReadKey();  
        }
    }
}
