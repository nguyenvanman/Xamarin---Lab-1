using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            var sum = number1 + number2;
            char[] array = sum.ToString().ToCharArray();
            Array.Reverse(array);
            Console.WriteLine("Revert sum: " + new string(array));
            Console.ReadKey();
        }
    }
}
