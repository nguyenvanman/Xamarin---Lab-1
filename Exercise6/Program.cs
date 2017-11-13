using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first edge: ");
            var firstEdge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second edge: ");
            var secondEdge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third edge: ");
            var thirdEdge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type: " + GetTypeOfTriangle(firstEdge, secondEdge, thirdEdge));
            Console.WriteLine("Perimeter: " + CalculatePerimeter(firstEdge, secondEdge, thirdEdge));
            Console.WriteLine("Area: " + CalculateArea(firstEdge, secondEdge, thirdEdge));
            Console.ReadKey();
        }
        static bool IsEdgesOfTriangle(int firstEdge, int secondEdge, int thirdEdge)
        {
            return (firstEdge + secondEdge > thirdEdge && secondEdge + thirdEdge > firstEdge &&
                    thirdEdge + firstEdge > secondEdge);
        }

        static int CalculatePerimeter(int firstEdge, int secondEdge, int thirdEdge)
        {
            if (IsEdgesOfTriangle(firstEdge, secondEdge, thirdEdge))
            {
                return firstEdge + secondEdge + thirdEdge;
            }
            return 0;
        }
        static int CalculateArea(int firstEdge, int secondEdge, int thirdEdge)
        {
            var perimeter = CalculatePerimeter(firstEdge, secondEdge, thirdEdge);
            var area = (int)Math.Sqrt(perimeter / 2 * (perimeter / 2- firstEdge) * (perimeter / 2 - secondEdge) *
                                 (perimeter / 2- thirdEdge));
            return area;

        }
        static string GetTypeOfTriangle(int firstEdge, int secondEdge, int thirdEdge)
        {
            if (!IsEdgesOfTriangle(firstEdge, secondEdge, thirdEdge))
            {
                return "Not a triangle";
            }
            if (firstEdge == secondEdge && secondEdge == thirdEdge)
            {
                return "Equilateral Triangle";
            }
            if (firstEdge == secondEdge || secondEdge == thirdEdge || thirdEdge == firstEdge)
            {
                return "Isosceles Triangle";
            }
            var maxEdge = (firstEdge > secondEdge && firstEdge > thirdEdge)
                ? firstEdge
                : (secondEdge > thirdEdge)
                    ? secondEdge
                    : thirdEdge;
            var minEdge = (firstEdge < secondEdge && firstEdge < thirdEdge)
                ? firstEdge
                : (secondEdge < thirdEdge)
                ? secondEdge
                : thirdEdge;
            var edge = firstEdge + secondEdge + thirdEdge - maxEdge - minEdge;
            if (maxEdge * maxEdge == edge * edge + minEdge * minEdge) return "Square Triangle";
            return "Normal Triangle";
        }
    }
}
