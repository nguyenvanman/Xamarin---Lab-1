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
            var firstEdge = ReadInputInt("Enter the first edge: ");
            var secondEdge = ReadInputInt("Enter the second edge: ");
            var thirdEdge = ReadInputInt("Enter the third edge: ");
            if (IsEdgesOfTriangle(firstEdge, secondEdge, secondEdge))
            {
                Console.WriteLine("Type: " + GetTypeOfTriangle(firstEdge, secondEdge, thirdEdge));
                Console.WriteLine("Perimeter: " + CalculatePerimeter(firstEdge, secondEdge, thirdEdge));
                Console.WriteLine("Area: " + CalculateArea(firstEdge, secondEdge, thirdEdge));
            }
            else
            {
                Console.WriteLine("Not a triangle");
            }
            Console.ReadKey();
        }
        static int ReadInputInt(string input)
        {
            Console.Write(input);
            return Convert.ToInt32(Console.ReadLine());
        }
        static bool IsEdgesOfTriangle(int firstEdge, int secondEdge, int thirdEdge)
        {
            return (firstEdge + secondEdge > thirdEdge && secondEdge + thirdEdge > firstEdge &&
                    thirdEdge + firstEdge > secondEdge);
        }
        static int CalculatePerimeter(int firstEdge, int secondEdge, int thirdEdge)
        {
            return firstEdge + secondEdge + thirdEdge;
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
            if (firstEdge == secondEdge && secondEdge == thirdEdge)
            {
                return "Equilateral Triangle";
            }
            if (firstEdge == secondEdge || secondEdge == thirdEdge || thirdEdge == firstEdge)
            {
                return "Isosceles Triangle";
            }
            var sqrFirst = firstEdge * firstEdge;
            var sqrSecond = secondEdge * secondEdge;
            var sqrThird = thirdEdge * thirdEdge;
            if ((sqrFirst + sqrSecond - sqrThird) * (sqrFirst - sqrSecond + sqrThird) *
                (-sqrFirst + sqrSecond + sqrThird) == 0)
            {
                return "Square Triangle";
            }
            return "Normal Triangle";
        }
    }
}
