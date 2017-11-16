using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3, 4, 5);
            var rectangle = new Rect(4, 5);
            var circle = new Circle(2);

            Console.WriteLine("Triangle: ");
            Show(triangle);
            Console.WriteLine("Rect: ");
            Show(rectangle);
            Console.WriteLine("Circle");
            Show(circle);
            Console.ReadKey();
        }
        static void Show(Shape obj)
        {
            Console.WriteLine("\tArea: " + obj.GetArea());
            Console.WriteLine("\tPerimeter: " + obj.GetPerimeter());
        }
    }
}
