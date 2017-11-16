using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise5
{
    class Triangle : Shape
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
        public override double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));

        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}
