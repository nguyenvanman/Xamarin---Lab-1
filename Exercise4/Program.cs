using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Greatest Common Divisor
            Console.Write("Enter value1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greatest common divisor value: " + greatestCommonDivisor(value1, value2));
            Console.ReadKey();

        }
        static int greatestCommonDivisor(int value1, int value2)
        {
            return (value2 == 0) ? value1 : greatestCommonDivisor(value2, value1 % value2);
        }
      
    }
}
