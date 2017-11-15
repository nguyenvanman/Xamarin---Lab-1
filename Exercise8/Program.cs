using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static bool IsPrimeNumber(int number)
        {
            if (number < 2) return false;
            for (int i = (int)Math.Sqrt(number); i >= 2; i--)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write(i + "\t");
                }
            }
            Console.ReadKey();
        }
    }
}
