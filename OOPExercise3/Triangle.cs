﻿using System;
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
            var perimeter = GetPerimeter();
            return Math.Sqrt(perimeter / 2 * (perimeter / 2 - A) * (perimeter / 2 - B) * (perimeter / 2 - C));
        }

        public string GetTrianglesType()
        {
            var sqrA = A * A;
            var sqrB = B * B;
            var sqrC = C * C;
            if (A == B && B == C)
            {
                return "";
            }
            if (A == B|| B == C || C == A)
            {
                if ((sqrA + sqrB - sqrC) * (sqrA - sqrB + sqrC) * (-sqrA + sqrB + sqrB) == 0)
                {
                    return "vuong can";
                }
                else
                {
                    return "can";
                }
            }
            if ((sqrA + sqrB - sqrC) * (sqrA - sqrB + sqrC) * (-sqrA + sqrB + sqrB) == 0)
            {
                return "vuong";
            }
            return "thuong";
        }
    }
}