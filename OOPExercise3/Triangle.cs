using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsTriangle()
        {
            return (A + B - C > 0 && A - B + C > 0 && -A + B + C > 0) ;
        }
        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        public string GetTrianglesType()
        {
            var sqrA = A * A;
            var sqrB = B * B;
            var sqrC = C * C;
            if (A == B && B == C)
            {
                return "equilateral triangle";
            }
            bool isSquare = (sqrA + sqrB - sqrC) * (sqrA - sqrB + sqrC) * (-sqrA + sqrB + sqrB) == 0;
            if (A == B|| B == C || C == A)
            {
                if (isSquare)
                {
                    return "isosceles and right triangle";
                }
                else
                {
                    return "isosceles triangle";
                }
            }
            if (isSquare)
            {
                return "right triangle";
            }
            return "normal triangle";
        }
    }
}
