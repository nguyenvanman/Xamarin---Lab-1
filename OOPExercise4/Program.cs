using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect rectangle = new Rect(4, 5);
            Console.WriteLine("Area: " + rectangle.GetArea());
            Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
            Console.ReadKey();
        }
    }
}
