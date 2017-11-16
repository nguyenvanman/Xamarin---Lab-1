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
            Fraction fraction1 = (new Fraction(5, 9)).Minimal();
            Fraction fraction2 = (new Fraction(4, 7).Minimal());
            Console.WriteLine("Fraction 1 : " + fraction1.ToString());
            Console.WriteLine("Fraction 2 : " + fraction2.ToString());

            Fraction addFraction = fraction1 + fraction2;
            Fraction subFraction = fraction1 - fraction2;
            Fraction mulFraction = fraction1 * fraction2;
            Fraction divFraction = fraction1 / fraction2;
            Fraction invertFraction = !fraction1;

            Console.WriteLine("operator + : " + addFraction.ToString());
            Console.WriteLine("operator - : " + subFraction.ToString());
            Console.WriteLine("operator * : " + mulFraction.ToString());
            Console.WriteLine("operator / : " + divFraction.ToString());
            Console.WriteLine("operator ! : " + invertFraction.ToString());

            Console.WriteLine("operator > : " + (fraction1 > fraction2));
            Console.WriteLine("operator < : " + (fraction1 < fraction2));
            Console.WriteLine("operator >= : " + (fraction1 >= fraction2));
            Console.WriteLine("operator <= : " + (fraction1 <= fraction2));

            Console.ReadKey();
        }
    }
}
