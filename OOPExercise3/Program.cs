using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(35, 4, 5);
            if (triangle.IsTriangle() == true)
            {
                Console.WriteLine("Type: " + triangle.GetTrianglesType());
                Console.WriteLine("Perimeter: " + triangle.GetPerimeter());
                Console.WriteLine("Area: " + triangle.GetArea());
            }
            else
            {
                Console.WriteLine("Not a triangle");
            }
            Console.ReadKey();
        }
    }
}
