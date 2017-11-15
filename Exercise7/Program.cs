using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateFibonaci(number));
            Console.ReadKey();
        }
        static int CalculateFibonaci(int n)
        {
            int[] fibonaci = new int[n + 1];
            fibonaci[0] = 1;
            fibonaci[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
            }
            return fibonaci[n - 1];
        }
    }
}
