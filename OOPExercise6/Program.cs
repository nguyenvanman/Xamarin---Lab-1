using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var fraction1 = (new Fraction(5, 9)).Minimal();
            var fraction2 = (new Fraction(4, 7).Minimal());
            Console.WriteLine("Fraction 1 : " + fraction1);
            Console.WriteLine("Fraction 2 : " + fraction2);

            var addFraction = fraction1 + fraction2;
            var subFraction = fraction1 - fraction2;
            var mulFraction = fraction1 * fraction2;
            var divFraction = fraction1 / fraction2;
            var invertFraction = !fraction1;

            Console.WriteLine("operator + : " + addFraction);
            Console.WriteLine("operator - : " + subFraction);
            Console.WriteLine("operator * : " + mulFraction);
            Console.WriteLine("operator / : " + divFraction);
            Console.WriteLine("operator ! : " + invertFraction);

            Console.WriteLine("operator > : " + (fraction1 > fraction2));
            Console.WriteLine("operator < : " + (fraction1 < fraction2));
            Console.WriteLine("operator >= : " + (fraction1 >= fraction2));
            Console.WriteLine("operator <= : " + (fraction1 <= fraction2));

            Console.ReadKey();
        }
    }
}
