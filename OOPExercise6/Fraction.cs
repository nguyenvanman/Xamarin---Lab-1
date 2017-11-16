using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise6
{
    class Fraction
    {
        public int A { get; set; }
        public int B { get; set; }

        public Fraction(int a, int b)
        {
            A = a;
            B = b;
        }

        public int GetGreatestCommonDivisor(int number1, int number2)
        {
            return (number2 == 0) ? number1 : GetGreatestCommonDivisor(number2, number1 % number2);
        }

        public Fraction Minimal()
        {
            var greatestCommonDivisor = GetGreatestCommonDivisor(A, B);
            A = A / greatestCommonDivisor;
            B = B / greatestCommonDivisor;
            return this;
        }

        public override string ToString() => $"{A}:{B}";
        public static Fraction operator + (Fraction fraction1, Fraction fraction2)
        {
            return (new Fraction(fraction1.A * fraction2.B + fraction2.A * fraction1.B,
                fraction1.B * fraction2.B)).Minimal();
        }

        public static Fraction operator - (Fraction fraction1, Fraction fraction2)
        {
            return (new Fraction(fraction1.A * fraction2.B - fraction2.A * fraction1.B,
                fraction1.B * fraction2.B)).Minimal();
        }
        public static Fraction operator * (Fraction fraction1, Fraction fraction2)
        {
            return (new Fraction(fraction1.A * fraction2.A, fraction1.B * fraction2.B)).Minimal();
        }
        public static Fraction operator / (Fraction fraction1, Fraction fraction2)
        {
            return (new Fraction(fraction1.A * fraction2.B, fraction1.B * fraction2.A));
        }
        public static bool operator > (Fraction fraction1, Fraction fraction2)
        {
            return (fraction1 - fraction2).A * (fraction1 - fraction2).B > 0;
        }
        public static bool operator < (Fraction fraction1, Fraction fraction2)
        {
            return fraction2 > fraction1;
        }
        public static bool operator >= (Fraction fraction1, Fraction fraction2)
        {
            return !(fraction1 < fraction2);
        }
        public static bool operator <= (Fraction fraction1, Fraction fraction2)
        {
            return !(fraction1 > fraction2);
        }
        public static Fraction operator ! (Fraction fraction)
        {
            return new Fraction(fraction.B, fraction.A).Minimal();
        }
    }
}
