using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //1. if_else
            if (number == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (number == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (number == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (number == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (number == 5)
            {
                Console.WriteLine("Thursday");
            }
            else if (number == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (number == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
            //2. switch_case
            switch (number)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            //3.Array
            String[] listDays = { "Invalid day", "Sunday", "Monday", "Tuesday", "Wedndesday", "Thursday", "Friday", "Saturday" };
            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(listDays[number]);
            }
            else
            {
                Console.WriteLine(listDays[0]);
            }
           
            Console.ReadKey();
        }
        
    }
}
