using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day: ");
            var day = Console.ReadLine();


            var day1 = "ngay " + day[0]+ day[1] + " thang " + day[3] + day[4] + " nam " + day[6] + day[7] + day[8] + day[9];
            Console.WriteLine(day1);

            var day2 = $"ngay {day[0]}{day[1]} thang {day[3]}{day[4]} nam {day[6]}{day[7]}{day[8]}{day[9]}";
            Console.WriteLine(day2);

            var day3 = String.Format("ngay {0}{1} thang {2}{3} nam {4}{5}{6}{7}", day[0], day[1], day[3], day[4],
                day[6], day[7], day[8], day[9]);
            Console.WriteLine(day3);

            var date = Convert.ToInt32(day[0].ToString() + day[1]);
            var month = Convert.ToInt32(day[3].ToString() + day[4]);
            var year = Convert.ToInt32(day[6].ToString() + day[7] + day[8] + day[9]);
            var day4 = new DateTime(year, month, date);
            var day5 = day4.ToString("'ngay' dd 'thang' MM 'nam' yyyy");
            Console.WriteLine(day5);
            
            Console.ReadKey();

        }
    }
}
